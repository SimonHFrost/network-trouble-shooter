using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NetworkTroubleShooter {
	public class StringChecker {
		private const string _statusGood = "Good";
		private const string _statusBad = "Error";

		public string CheckValidity(string message, TaskType taskType) {
			if (taskType == TaskType.Ping) {
				return CheckValidPing(message);
			} else if (taskType == TaskType.Dns) {
				return CheckValidDns(message);
			}
			return "";
		}

		public string CheckValidPing(string message) {
			Regex regex = new Regex(@"Reply from");
			return regex.IsMatch(message) ? _statusGood : _statusBad;
		}

		public string CheckValidDns(string message) {
			Regex regex = new Regex(@"202.180.64.10");
			return regex.IsMatch(message) ? _statusGood : _statusBad;
		}
	}
}
