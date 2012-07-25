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
			textBoxEnterModem.Text = modemIp;
			textBoxEnterRouter.Text = routerIp;
			textBoxEnterGoogle.Text = googleAddress;
			textBoxEnterDns.Text = googleAddress;
		}

		private void btnPingModem_Click(object sender, EventArgs e) {
			string command = string.Format("ping {0}", textBoxEnterModem.Text);
			CommandRunner.RunCommand(textBoxPingModem, command);
		}

		private void btnPingRouter_Click(object sender, EventArgs e) {
			string command = string.Format("ping {0}", textBoxEnterRouter.Text);
			CommandRunner.RunCommand(textBoxPingRouter, command);
		}

		private void btnPingGoogle_Click(object sender, EventArgs e) {
			string command = string.Format("ping {0}", textBoxEnterGoogle.Text);
			CommandRunner.RunCommand(textBoxPingGoogle, command);
		}

		private void btnCheckDNS_Click(object sender, EventArgs e) {
			string command = string.Format("nslookup {0}", textBoxEnterDns.Text);
			CommandRunner.RunCommand(textBoxCheckDNS, command);
		}
	}
}
