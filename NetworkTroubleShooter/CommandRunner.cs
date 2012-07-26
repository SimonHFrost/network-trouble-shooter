using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetworkTroubleShooter {
	public class CommandRunner {
		private TextBox _textBox;
		private string _command;

		public CommandRunner(TextBox textBox, string command) {
			_textBox = textBox;
			_command = command;
		}

		public void RunCommand() {
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + _command);
			startInfo.RedirectStandardOutput = true;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;

			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();

			string output = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			_textBox.Text = output; 
		}

	}
}
