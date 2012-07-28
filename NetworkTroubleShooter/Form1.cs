using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NetworkTroubleShooter {
	public partial class Form1 : Form {
		private const string _modemIp = "192.168.1.1";
		private const string _routerIp = "192.168.1.2";
		private const string _googleAddress = "www.google.com";
		private StringChecker _stringChecker;

		public Form1() {
			InitializeComponent();

			textBoxEnterModem.Text = _modemIp;
			textBoxEnterRouter.Text = _routerIp;
			textBoxEnterGoogle.Text = _googleAddress;
			textBoxEnterDns.Text = _googleAddress;

			_stringChecker = new StringChecker();
		}

		private void btnPingModem_Click(object sender, EventArgs e) {
			string command = string.Format("ping {0} -n 1", textBoxEnterModem.Text);
			Thread thread = new Thread(new ParameterizedThreadStart(DoWorkAsync));
			thread.Start(new Task(textBoxPingModem, command, TaskType.Ping));
		}

		private void btnPingRouter_Click(object sender, EventArgs e) {
			string command = string.Format("ping {0} -n 1", textBoxEnterRouter.Text);
			Thread thread = new Thread(new ParameterizedThreadStart(DoWorkAsync));
			thread.Start(new Task(textBoxPingRouter, command, TaskType.Ping));
		}

		private void btnPingGoogle_Click(object sender, EventArgs e) {
			string command = string.Format("ping {0} -n 1", textBoxEnterGoogle.Text);
			Thread thread = new Thread(new ParameterizedThreadStart(DoWorkAsync));
			thread.Start(new Task(textBoxPingGoogle, command, TaskType.Ping));
		}

		private void btnCheckDNS_Click(object sender, EventArgs e) {
			string command = string.Format("nslookup {0}", textBoxEnterDns.Text);
			Thread thread = new Thread(new ParameterizedThreadStart(DoWorkAsync));
			thread.Start(new Task(textBoxCheckDNS, command, TaskType.Dns));
		}

		private void DoWorkAsync(object theObject) {
			Task task = (Task)theObject;
			
			string command = task.Command;
			TextBox textBox = task.TextBox;
			TaskType taskType = task.TaskType;

			CommandRunner commandRunner = new CommandRunner(command);
			string output = commandRunner.RunCommand();
			
			string status = _stringChecker.CheckValidity(output, taskType);
			textBoxPingModem.Invoke(() => { textBox.Text = status; });
		}
	}
}
