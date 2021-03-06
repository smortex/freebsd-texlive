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
using System.Collections.Generic;
using System.Diagnostics;

// This program will build all ports for TeXLive except print/texlive-core
// which is provided in the freebsd-texlive Subversion repository.
//
// Before running this tool, you have to install print/texlice-core (since some
// TeXLive packages include files that are provided by texlive-core, this
// utility checks the filesystem to determine if files will be installed when
// installing the package are skipped because they are part of texlive-core.
//
// You will have to specify path information at the command line. The first
// argument is the location of a directory containing all .tlpobj files
// provided in TeXLive tarballs, the second one is the location of the ports
// tree where TeXLive ports are to be built.

namespace TeXLive
{
	class TLPort
	{

		public static int Verbosity {
			get { return verbosity; }
		}

		public static List<string> Run (string filename, string arguments, string working_direcotry)
		{
			if (Verbosity >= 2)
				Console.WriteLine ("{2}% {0} {1}", filename, arguments, working_direcotry);

			List<string> res;
			var p = new Process ();
			var psi = new ProcessStartInfo (filename, arguments);
			try {
				psi.WorkingDirectory = working_direcotry;
				psi.RedirectStandardOutput = true;
				psi.RedirectStandardError = true;
				psi.UseShellExecute = false;
				p.StartInfo = psi;
				p.Start ();
				var stdout = p.StandardOutput.ReadToEndAsync ();
				var stderr = p.StandardError.ReadToEndAsync ();
				p.WaitForExit ();

				res = new List<string> (stdout.Result.Split ('\n'));

				if (Verbosity >= 3)
					Console.Write (stdout.Result);

				if ((p.ExitCode != 0) || (Verbosity >= 3)) {
					Console.Error.Write (stderr.Result);
				}

				if (p.ExitCode != 0)
					throw new Exception (string.Format ("{0} returned {1}", filename, p.ExitCode));
			} finally {
				p.Dispose ();
			}

			return res;
		}

		private static int verbosity;
		private static PackageCollection packages;

		private static void ShowHelp (NDesk.Options.OptionSet options)
		{
			Console.WriteLine ("Usage: {0} [OPTIONS]+ <tlpobjdir> <portsdir> <distdir>", AssemblyName ());
			Console.WriteLine ("Generate TeXLive FreeBSD ports");
			Console.WriteLine ();
			Console.WriteLine ("Options:");
			options.WriteOptionDescriptions (Console.Out);
		}

		private static string AssemblyName ()
		{
			return System.Reflection.Assembly.GetExecutingAssembly ().GetName ().Name;
		}

		public static int Main (string [] args)
		{
			List<string> extra;
			bool show_help = false;

			var p = new NDesk.Options.OptionSet  {
				{ "v|verbose", "Increase verbosity",   v => { ++verbosity; } },
				{ "h|help",    "Display this message", v => { show_help = v != null; } }
			};
			try {
				extra = p.Parse (args);
			} catch (NDesk.Options.OptionException e) {
				Console.Write ("{0}: ", AssemblyName ());
				Console.WriteLine (e.Message);
				Console.WriteLine ("Try `{0} --help' for more information.", AssemblyName ());
				return 1;
			}

			if (show_help) {
				ShowHelp (p);
				return 0;
			}

			if (extra.Count != 3) {
				ShowHelp (p);
				return 1;
			}

			packages = new PackageCollection (extra [0], extra [1], extra [2]);

			if (Verbosity >= 1)
				Console.Error.WriteLine ("===> Building package list (this takes a while)");

			// Read all scheme-*. They reference all collections, that in turn
			// reference each package.
			foreach (string s in System.IO.Directory.GetFiles (packages.TlpObjDir, "scheme-*")) {
				var fi = new System.IO.FileInfo (s);
				string package_name = fi.Name.Split ('.') [0];

				packages [package_name] = new DataPackage (package_name, packages);
			}

			int current = 1;
			foreach (Package pkg in packages.Values) {
				if (Verbosity >= 1)
					Console.WriteLine ("===> [{0,4}/{1}] print/texlive-{2}", current++, packages.Count, pkg.Name);

				if (pkg.Eligible) {
					if (!pkg.Exists) {
						pkg.CreatePort ();
						packages.moved.Remove (pkg.PortDirectory);
					} else {
						pkg.UpdatePort ();
					}
				} else {
					if (Verbosity >= 2)
						Console.Error.WriteLine ("{0}: not eligible for building a port.", pkg.Name);
				}
			}

			if (Verbosity >= 1)
				Console.Error.WriteLine ("===> Looking for resurected packages");

			packages.moved.RemoveAll (PortExist);


			// Detect deprecated packages
			if (Verbosity >= 1)
				Console.Error.WriteLine ("===> Looking for deleted packages");

			foreach (string path in System.IO.Directory.GetDirectories (System.IO.Path.Combine (packages.PortsDir, "print"))) {
				string s = System.IO.Path.GetFileName (path);
				if (s.StartsWith ("texlive-", StringComparison.Ordinal)) {
					if (!packages.ContainsKey (s.Substring (8))) {
						packages.moved.Add ("print/" + s);
						DeletePort (packages.PortsDir, System.IO.Path.Combine ("print", s));
					}
				}
			}

			packages.moved.Save ();

			return 0;
		}

		private static bool PortExist (string s)
		{
			return System.IO.Directory.Exists (System.IO.Path.Combine (packages.PortsDir, s));
		}

		/// <summary>
		/// Remove the ports from the repository
		/// </summary>
		static private void DeletePort (string PortsDir, string PortName)
		{
			Run ("git", string.Format ("rm -r {0}", System.IO.Path.Combine (PortsDir, PortName)), PortsDir);
		}
	}
}
