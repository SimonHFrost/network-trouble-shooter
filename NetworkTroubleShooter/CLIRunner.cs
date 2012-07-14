using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkTroubleShooter {
	public static class CLIRunner {
		public static void RunCommand(string command) {
			System.Diagnostics.ProcessStartInfo procStartInfo =
				new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
		}
	}
}
