using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetworkTroubleShooter {
	public static class CommandRunner {
		public static void RunCommand(TextBox textBox, string command) {
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + command);
			startInfo.RedirectStandardOutput = true;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;
			
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();

			string output = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			textBox.Text = output;
		}
	}
}
