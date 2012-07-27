using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetworkTroubleShooter {
	public class CommandRunner {
		private string _command;

		public CommandRunner(string command) {
			_command = command;
		}

		public string RunCommand() {
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + _command);
			startInfo.RedirectStandardOutput = true;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;

			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();

			string output = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return output; 
		}

	}
}
