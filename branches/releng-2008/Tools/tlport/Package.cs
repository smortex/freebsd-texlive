// Copyright (c) 2008, Romain Tartière <romain@blogreen.org>
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
using System.Diagnostics;

namespace TeXLive
{
	/// <summary>
	/// Abstract class for TeXLive packages.
	/// </summary>
	public abstract class Package: IPackage
	{
		protected string name;
		protected string short_description;
		protected string long_description;
		protected ArrayList depend;
		protected ArrayList files;
		protected PackageCollection collection;

		private string detect_file_name;

		/// <summary>
		/// Create the FreeBSD port of the package.
		/// </summary>
		public void CreatePort()
		{
			if (name == "core") {
				return; // Do not auto-generate this one!
			}
			Console.WriteLine("===> Creating print/texlive-{0}...", name);
			CreatePortDirectory();
			CreateMakefile();
			CreatePkgDescr();
			CreateDistinfo();
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
		private void CreateMakefile()
		{
			System.IO.StreamWriter makefile = new System.IO.StreamWriter(System.IO.Path.Combine(PortDirectory, "Makefile"));

			makefile.WriteLine("# New ports collection makefile for:\ttexlive-{0}", name);
			makefile.WriteLine("# Date created:\t\t{0}", DateTime.Now);
			makefile.WriteLine("# Whom:\t\t{0}", "romain@blogreen.org");
			makefile.WriteLine("#");
			makefile.WriteLine("# $FreeBSD$");
			makefile.WriteLine("#");
			makefile.WriteLine();
			makefile.WriteLine("PORTNAME=\t{0}", name);
			makefile.WriteLine("CATEGORIES=\tprint");
			if (files.Count == 0) {
				makefile.WriteLine("DISTFILES=\t# None");
			}
			makefile.WriteLine();
			makefile.WriteLine("MAINTAINER=\t{0}", "romain@blogreen.org");
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
			makefile.WriteLine("LSE_LZMA=\tyes");
			if (!System.IO.File.Exists(System.IO.Path.Combine(collection.TlpObjDir, name + ".doc.tlpobj"))) {
				makefile.WriteLine("NOPORTDOCS=\tyes");
			}
			if (!System.IO.File.Exists(System.IO.Path.Combine( collection.TlpObjDir, name + ".sources.tlpobj"))) {
				makefile.WriteLine("NOPORTSRC=\tyes");
			}
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
		private void CreateDistinfo()
		{
			Process p = new Process();
			ProcessStartInfo psi = new ProcessStartInfo("port", "fetch");
			psi.UseShellExecute = true;
			psi.WorkingDirectory = PortDirectory;
			p.StartInfo = psi;
			p.Start();
			p.WaitForExit();
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

					// Ensure this file is not already installed by texlive-core
					if (System.IO.File.Exists(detect_file_name)) {
						detect_file_name = null;
					}

					// Fallback on the first file listed in the archive that
					// does not exist on the filesystem.
					if (detect_file_name == null) {
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
				return ((files.Count > 0) || (depend.Count > 0));
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
						files.Add("share/" + s);
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
