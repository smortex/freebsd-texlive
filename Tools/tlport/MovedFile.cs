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
using System.IO;

namespace TeXLive
{
	public class MovedFile
	{
		public string FileName { get; set; }
		private List<string[]> Lines;
		
		public MovedFile (string FileName)
		{
			this.FileName = FileName;
			
			Lines = new List<string[]>();
			using (StreamReader sr = new StreamReader (FileName)) {
				do {
					string line = sr.ReadLine ();
					Lines.Add (line.Split ('|'));
				} while (!sr.EndOfStream);
			}
		}
		
		public void Add (string Port)
		{
			Add (Port, string.Format ("{0:yyyy}-{0:MM}-{0:dd}", DateTime.UtcNow), "Upstream support dropped");
		}
		
		public void Add (string Port, string Date, string Reason)
		{
			string[] line = new string[] { Port, "", Date, Reason };
			Lines.Add (line);
		}
		
		public bool Remove (string Port)
		{
			for (int i = 0; i < Lines.Count; i++) {
				if (Lines[i][0] == Port) {
					Lines.RemoveAt (i);
					return true;
				}		
			}
			return false;
		}

		public int RemoveAll (Predicate<string> match)
		{
			return Lines.RemoveAll (delegate(string[] obj) {
				return match (obj [0]);
			});
		}
		
		public bool HasPort (string Port)
		{
			foreach (string [] pieces in Lines) {
				if (pieces[0] == Port)
					return true;
			}
			return false;
		}
		
		public void Save ()
		{
			using (StreamWriter sw = new StreamWriter (FileName)) {
				foreach (string[] pieces in Lines) {
					sw.WriteLine (string.Format ("{0}|{1}|{2}|{3}", pieces[0], pieces[1], pieces[2], pieces[3]));
				}
			}
			FileInfo fi = new FileInfo(FileName);
			Process p = new Process ();
			ProcessStartInfo psi = new ProcessStartInfo ("git", string.Format("add {0}", fi.Name));
			psi.WorkingDirectory = fi.DirectoryName;
			psi.RedirectStandardOutput = true;
			psi.UseShellExecute = false;
			p.StartInfo = psi;
			p.Start();
			p.WaitForExit();
			p.Dispose ();
		}
	}
}

