using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkTroubleShooter {
	struct Task {
		public TextBox TextBox;
		public string Command;

		public Task(TextBox textBox, string command) {
			TextBox = textBox;
			Command = command;
		}
	}
}
