// Copyright (c) 2008-2012, Romain Tartière <romain@blogreen.org>
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following condition are met:
//
//    * Redistributions of source code must retain the above copyright notice,
//      this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright
//      notice, this list of conditions and the following disclaimer in the
//      documentation and/or other materials provided with the distribution.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
// POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace TeXLive
{
	/// <summary>
	/// Abstract class for TeXLive packages.
	/// </summary>
	public abstract class Package: IPackage
	{
		protected string name;
		protected int version;
		protected int epoch;
		protected string short_description;
		protected string long_description;
		protected ArrayList depend;
		protected ArrayList files;
		protected PackageCollection collection;

		private string detect_file_name;
		
		/// <summary>
		/// Check is a FreeBSD port for the TeXLive package exists.
		/// </summary>
		public bool Exists {
			get {
				return System.IO.Directory.Exists (PortDirectory);
			}
		}
		
		/// <summary>
		/// Get FreeBSD port's revision
		/// </summary>
		public int PortRevision {
			get {
				int res = 0;
				Process p = new Process();
				ProcessStartInfo psi = new ProcessStartInfo("make", "-V PORTREVISION");
				psi.UseShellExecute = true;
				psi.WorkingDirectory = PortDirectory;
				psi.RedirectStandardOutput = true;
				psi.UseShellExecute = false;
				p.StartInfo = psi;
				p.Start();
				p.WaitForExit();
				res = int.Parse (p.StandardOutput.ReadLine ());
				p.Dispose ();
				return res;
			}
		}
		
		/// <summary>
		/// Modification status of the port in the FreeBSD TeXLive VCS local checkout.
		/// The Makefile should just have it's version/date that changes.
		/// </summary>
		public bool LocalyModified {
			get {
				bool res;
				Process p = new Process();
				ProcessStartInfo psi = new ProcessStartInfo("svn", "diff");
				psi.WorkingDirectory = PortDirectory;
				psi.RedirectStandardOutput = true;
				psi.UseShellExecute = false;
				p.StartInfo = psi;
				p.Start();
				int modifications = 0;
				while (!p.StandardOutput.EndOfStream) {
					string s = p.StandardOutput.ReadLine ();
					if (s.StartsWith ("+") || s.StartsWith ("-"))
						modifications++;
				}
				res = modifications > 4;
				p.Dispose ();
				return res;
			}
		}

		/// <summary>
		/// Create the FreeBSD port of the package.
		/// </summary>
		public void CreatePort()
		{
			if (TLPort.Verbosity > 0)
				Console.WriteLine("===> Creating print/texlive-{0}...", name);
			CreatePortDirectory();
			CreateMakefile();
			CreatePkgDescr();
			CreateDistinfo();
			CreatePkgPlist ();
			Clean ();
			AddToVcs ();
		}
		
		/// <summary>
		/// Add the port to the VCS (currently subversion, no real plan to change that though)
		/// </summary>
		private void AddToVcs ()
		{
			Process p = new Process();
			ProcessStartInfo psi = new ProcessStartInfo("svn", string.Format ("add {0}", PortDirectory));
			if (TLPort.Verbosity < 2) {
				psi.RedirectStandardOutput = true;
				psi.UseShellExecute = false;
			} else {
				psi.UseShellExecute = true;
			}
			p.StartInfo = psi;
			p.Start();
			p.WaitForExit();
			p.Dispose ();
		}
		
		/// <summary>
		/// Update the FreeBSD port of the package
		/// </summary>
		public void UpdatePort ()
		{
			if (TLPort.Verbosity > 0)
				Console.WriteLine("===> Updating print/texlive-{0}...", name);
			
			// Makefile may need to be updated before generating distinfo
			CreateMakefile ();
			CreateDistinfo ();
			
			if (LocalyModified) {
				CreatePkgPlist ();
				Clean ();
			} else {
				Process p = new Process();
				ProcessStartInfo psi = new ProcessStartInfo("svn", "revert --quiet Makefile");
				psi.WorkingDirectory = PortDirectory;
				psi.UseShellExecute = true;
				p.StartInfo = psi;
				p.Start();
				p.WaitForExit();
				p.Dispose ();
			}
		}

		/// <summary>
		/// Create the FreeBSD port of the pachage and all FreeBSD ports it
		/// requires.
		/// </summary>
		public void CreatePortRecursive()
		{
			CreatePort();
			foreach (Package package in Depends) {
				package.CreatePortRecursive();
			}
		}

		/// <summary>
		/// Create the FreeBSD port's directory.
		/// </summary>
		private void CreatePortDirectory()
		{
			System.IO.Directory.CreateDirectory(PortDirectory);
		}

		/// <summary>
		/// Create the Makefile of the FreeBSD port.
		/// </summary>
		private void CreateMakefile ()
		{
			List<string> header = new List<string> ();
			
			string makefile_path = System.IO.Path.Combine(PortDirectory, "Makefile");

			int oldversion = 0;
			
			// If there is alread a Makefile, copy it's header
			if (System.IO.File.Exists (makefile_path)) {
				System.IO.StreamReader old_makefile = new System.IO.StreamReader (makefile_path);
				bool read_header = true;
				while (!old_makefile.EndOfStream) {
					string line = old_makefile.ReadLine ();
					if (read_header && line.StartsWith ("#"))
						header.Add (line);
					else {
						read_header = false;
						if (line.StartsWith ("PORTEPOCH=\t"))
							epoch = int.Parse (line.Split ('\t')[1]);
						if (line.StartsWith ("PORTVERSION=\t"))
							oldversion = int.Parse (line.Split ('\t')[1]);
					}
				}
				old_makefile.Close ();
			}

			if (oldversion > version)
				epoch++;
			
			// Create the new makefile
			System.IO.StreamWriter makefile = new System.IO.StreamWriter(makefile_path);

			if (header.Count == 0) {
				makefile.WriteLine("# $FreeBSD$");
			} else {
				foreach (string line in header)
					makefile.WriteLine (line);
			}
			makefile.WriteLine();
			makefile.WriteLine("PORTNAME=\t{0}", name);
			makefile.WriteLine ("PORTVERSION=\t{0}", version);
			if (epoch > 0) {
				makefile.WriteLine ("PORTEPOCH=\t{0}", epoch);
			}
			makefile.WriteLine("CATEGORIES=\tprint");
			if (files.Count == 0) {
				makefile.WriteLine("DISTFILES=\t# None");
			}
			makefile.WriteLine();
			makefile.WriteLine("MAINTAINER=\t{0}", "romain@FreeBSD.org");
			makefile.WriteLine("COMMENT=\t{0}", short_description);

			if (depend.Count > 0) {
				ArrayList dependencies = new ArrayList();
				foreach (string dep in depend) {
				 	collection[dep].Detect(dependencies);
				}

				int i = 0;
				string []x;
				x = new string[dependencies.Count];
				foreach (string dep in dependencies) {
					x[i++] = dep;
				}

				makefile.WriteLine();
				makefile.WriteLine("RUN_DEPENDS=\t{0}", string.Join(" \\\n\t\t", x));
			}
			makefile.WriteLine();

			List<string> options_define = new List<string> ();
			List<string> options_exclude = new List<string> ();

			if (System.IO.File.Exists (System.IO.Path.Combine (collection.TlpObjDir, name + ".doc.tlpobj")))
				options_define.Add ("DOCS");
			else
				options_exclude.Add ("DOCS");

			if (System.IO.File.Exists (System.IO.Path.Combine (collection.TlpObjDir, name + ".source.tlpobj")))
				options_define.Add ("SRCS");

			if (options_define.Count > 0)
				makefile.WriteLine ("OPTIONS_DEFINE=\t{0}", String.Join (" ", options_define));
			if (options_exclude.Count > 0)
				makefile.WriteLine ("OPTIONS_EXCLUDE=\t{0}", String.Join (" ", options_exclude));

			makefile.WriteLine (".include <bsd.port.options.mk>");

			makefile.WriteLine();
			makefile.WriteLine(".include \"${.CURDIR}/../../print/texlive-core/bsd.texlive.mk\"");
			makefile.WriteLine(".include <bsd.port.mk>");
			makefile.Close();
		}

		/// <summary>
		/// Create the pkg-desc file of the FreeBSD port.
		/// </summary>
		private void CreatePkgDescr()
		{
			System.IO.StreamWriter pkgdescr = new System.IO.StreamWriter(System.IO.Path.Combine(PortDirectory, "pkg-descr"));
			pkgdescr.WriteLine(LongDescription);
			pkgdescr.Close();
		}

		/// <summary>
		/// Rely on port(1) to fetch the source tarball and build distinfo
		/// </summary>
		private bool CreateDistinfo()
		{
			bool result;
			Process p = new Process();
			ProcessStartInfo psi = new ProcessStartInfo("make", "makesum FETCH_CMD=false");
			if (TLPort.Verbosity < 2) {
				psi.RedirectStandardOutput = true;
				psi.RedirectStandardError = true;
				psi.UseShellExecute = false;
			} else {
				psi.UseShellExecute = true;
			}
			psi.WorkingDirectory = PortDirectory;
			p.StartInfo = psi;
			p.Start ();
			p.WaitForExit ();
			result = p.ExitCode == 0;
			p.Dispose ();
			return result;
		}
		
		/// <summary>
		/// Generate a pkg-plist file.
		/// </summary>
		private void CreatePkgPlist ()
		{
			Process p = new Process ();
			ProcessStartInfo psi = new ProcessStartInfo ("make", "pkg-plist");
			if (TLPort.Verbosity < 2) {
				psi.RedirectStandardOutput = true;
				psi.RedirectStandardError = true;
				psi.UseShellExecute = false;
			} else {
				psi.UseShellExecute = true;
			}
			psi.WorkingDirectory = PortDirectory;
			p.StartInfo = psi;
			p.Start ();
			p.WaitForExit ();
			p.Dispose ();
		}
		
		/// <summary>
		/// Clean a port
		/// </summary>
		private void Clean ()
		{
			Process p = new Process ();
			ProcessStartInfo psi = new ProcessStartInfo ("make", "clean");
			psi.UseShellExecute = true;
			psi.WorkingDirectory = PortDirectory;
			p.StartInfo = psi;
			p.Start ();
			p.WaitForExit ();
			p.Dispose ();
		}

		/// <summary>
		/// Register ports dependencies.
		/// </summary>
		/// <param name="dependencies">
		/// A <see cref="ArrayList"/> of dependencies to complete.
		/// </param>
		private void Detect(ArrayList dependencies)
		{
			if ((files.Count > 0) && (null != DetectFileName)) {
				string s = string.Format("${{LOCALBASE}}/{0}:${{PORTSDIR}}/print/texlive-{1}", DetectFileName, name);
				if (dependencies.IndexOf(s) == -1) {
					dependencies.Add(s);
				}
			} else {
				// This package does not provide any file.
				// The port needs to depend on packages this package depends on
				foreach (string dep in depend) {
					collection[dep].Detect(dependencies);
				}
			}
		}

		//// <summary>
		///  File to look for to determine if the package is installed.
		/// </summary>
		public string DetectFileName {
			get {
				if (detect_file_name == null) {

					// Try to depend on a file whose name is relevant.
					foreach (string file in files) {
						if (file.EndsWith("/" + name + ".cls")) {
							detect_file_name = file;
							break;
						}
						if (file.EndsWith("/" + name + ".sty")) {
							detect_file_name = file;
							break;
						}
						if (file.EndsWith("/" + name + ".tex")) {
							detect_file_name = file;
							break;
						}
					}

					// Fallback on the first file listed in the archive that
					// does not exist on the filesystem.
					if (detect_file_name == null) {
						if (TLPort.Verbosity > 1)
							Console.Error.WriteLine("Cannot be smart with {0}", name);
						foreach (string file in files) {
							if (!System.IO.File.Exists(file)) {
								detect_file_name = file;
								break;
							}
						}
					}
				}

				return detect_file_name;
			}
		}

		/// <summary>
		/// Short description of the package
		/// </summary>
		public string ShortDescription {
			get { return short_description; }
		}

		/// <summary>
		/// Long description of the package
		/// </summary>
		public string LongDescription {
			get {
				if (null != long_description) {
					return long_description.Trim();
				} else {
					return null;
				}
			}
		}

		/// <summary>
		/// Package Name.
		/// </summary>
		public string Name {
			get {
				return name;
			}
		}

		/// <summary>
		/// Files provided in the package.
		/// </summary>
		public ArrayList Files {
			get {
				return files;
			}
		}

		/// <summary>
		/// An array of Pachage dependencies.
		/// </summary>
		public ArrayList Depends {
			get {
				return depend;
			}
		}

		/// <sumary>
		/// The directory where the FreeBSD port lives.
		/// </sumary>
		public string PortDirectory {
			get {
				return System.IO.Path.Combine(System.IO.Path.Combine(collection.PortsDir, "print"), "texlive-" + name);
			}
		}

		/// <summary>
		/// Determines if the package is eligible for creating a port.
		/// </summary>
		public bool Eligible {
			get {
				return ((files.Count > 0) || (depend.Count > 0)) && (name != "core");
			}
		}

	}

	/// <summary>
	/// TeXLive class for the package that provide all binaries.
	/// </summary>
	class BinPackage: Package
	{
		public BinPackage(PackageCollection AllPackage) {
			name = "core";
			files = new ArrayList();
			depend = new ArrayList();
			files.Add("bin/tex");
			collection = AllPackage;
		}
	}

	/// <summary>
	/// TeXLive class for all non-binary TeXLive packages.
	/// </summary>
	public class DataPackage : Package
	{
		private bool bin_depend;

		/// <summary>
		/// Create a TeXLive package based on the tlpobj file that describe it.
		/// </summary>
		/// <param name="PackageName">
		/// A <see cref="System.String"/> with the name of the package in the
		/// current directory, without the .tlpobj extension.
		/// </param>
		public DataPackage(string PackageName, PackageCollection AllPackages)
		{
			files = new ArrayList();
			depend = new ArrayList();
			bin_depend = false;
			collection = AllPackages;

			string FileName = System.IO.Path.Combine(collection.TlpObjDir, PackageName + ".tlpobj");
			System.IO.StreamReader tlobj = new System.IO.StreamReader(FileName, true);

			string Distfile = System.IO.Path.Combine (collection.DistDir, PackageName + ".tar.xz");
			version = int.Parse (System.IO.File.GetLastWriteTime (Distfile).ToString ("yyyyMMdd"));
			epoch = 0;

			// Read package information
			string s;
			while (null != (s = tlobj.ReadLine())) {
				if (s.StartsWith("name ")) {
					name = s.Substring(5);
				}
				if (s.StartsWith("shortdesc ")) {
					short_description = s.Substring(10);
				}
				if (s.StartsWith("longdesc ")) {
					long_description += s.Substring(9) + '\n';
				}
				if (s.StartsWith(" ")) {
					s = s.Substring(1);
					if (s.StartsWith("texmf")) {
						// We install only texmf* files.

						// ...with a few exceptions (files installed by texlive-core)
						if (System.IO.File.Exists("/usr/local/" + s))
							continue;

						files.Add("share/" + s);
					} else if (s.StartsWith("RELOC/")) {
						files.Add("share/texmf-dist" + s.Substring (5));
					}
				}

				if (s.StartsWith("depend ")) {
					if (s.EndsWith(".ARCH")) {
						// Binary packages are provided by print/texlive
						bin_depend = true;
					} else {
						string dependency_name = s.Substring(7);
						try {
							if (!AllPackages.ContainsKey(dependency_name)) {
								collection[dependency_name] = new DataPackage(dependency_name, collection);
							}

							depend.Add(dependency_name);
						} catch (System.IO.FileNotFoundException) {
							Console.Error.WriteLine("Cannot find package {0}!", dependency_name);
						}
					}
				}
			}

			// Binaries are provided by a single special port.
			if (bin_depend) {
				if (!AllPackages.ContainsKey("core")) {
					collection["core"] = new BinPackage(collection);
				}
				depend.Add("core");
			}

			// FIXME We should not fill-in missing fields
			if (short_description == null) {
				short_description = string.Format("The {0} package", name);
			}
			if (long_description == null) {
				long_description = string.Format("The {0} package", name);
			}
		}
	}
}
