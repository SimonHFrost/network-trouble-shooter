using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkTroubleShooter {
	public partial class Form1 : Form {
		private const string modemIp = "192.168.1.1";
		private const string routerIp = "192.168.1.2";
		private const string googleAddress = "www.google.com";

		public Form1() {
			InitializeComponent();
		}

		private void btnPingModem_Click(object sender, EventArgs e) {
			textBoxPingModem.Text += "Hey bro\n";
			CLIRunner.RunCommand(string.Format("ping {0}", modemIp));
		}

		private void btnPingRouter_Click(object sender, EventArgs e) {

		}

		private void btnPingGoogle_Click(object sender, EventArgs e) {

		}

		private void btnCheckDNS_Click(object sender, EventArgs e) {

		}

		private void StartCommand(string command) {

		}
	}
}
