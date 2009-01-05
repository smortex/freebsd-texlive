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
using System.Collections.Generic;

// This program will build all ports for TeXLive except print/texlive-core
// which is provided in the freebsd-texlive Subversion repository.
//
// Before running this tool, you have to install print/texlice-core (since some
// TeXLive packages include files that are provided by texlive-core, this
// utility checks the filesystem to determine if files will be installed when
// installing the package are skipped because they are part of texlive-core.
//
// You will have to tweak the path information in the Main function bellow to
// fit your system configuration.

namespace TeXLive
{
	class TlPort
	{

		public static void Main(string[] args)
		{

			PackageCollection packages = new PackageCollection();
			packages.TlpObjDir =
				"/home/romain/Desktop/TeXLive/local/tlpkg/tlpobj";
			packages.PortsDir = "/home/romain/Projects/freebsd-texlive";

			// Read all scheme-*. They reference all collections, that in turn
			// reference each package.
			foreach (string s in System.IO.Directory.GetFiles(
			                               packages.TlpObjDir, "scheme-*")) {
				System.IO.FileInfo fi = new System.IO.FileInfo(s);
				string package_name = fi.Name.Split('.')[0];

				packages[package_name] = 
					new DataPackage(package_name, packages);
			}


			foreach (Package pkg in packages.Values) {
				if (pkg.Eligible) {
					pkg.CreatePort();
				} else {
					Console.Error.WriteLine("{0}: not eligible for building "+
					                        "a port.", pkg.Name);
				}
			}
		}
	}
}
