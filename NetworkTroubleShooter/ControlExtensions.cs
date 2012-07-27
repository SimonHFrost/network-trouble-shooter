using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkTroubleShooter {
	public static class ControlExtensions {
		public static void Invoke(this Control control, Action action) {
			if (control.InvokeRequired)
				control.Invoke(new MethodInvoker(action), null);
			else {
				action.Invoke();
			}
		}
	}
}
