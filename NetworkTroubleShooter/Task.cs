using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkTroubleShooter {
	/// <summary>
	/// Needed because extra threads can only take one param
	/// </summary>
	struct Task {
		public TextBox TextBox;
		public string Command;
		public Label Label;
		public TaskType TaskType;

		public Task(TextBox textBox, string command, Label label, TaskType taskType) {
			TextBox = textBox;
			Command = command;
			Label = label;
			TaskType = taskType;
		}
	}
}
