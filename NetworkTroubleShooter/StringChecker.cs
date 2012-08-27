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
			return _statusBad;
		}

		private string CheckValidPing(string message) {
			Regex regex = new Regex(@"([0-9]*)ms");
			Match match = regex.Match(message);

			if (match.Success) {
				int parseResult;
				if (int.TryParse(match.Groups[1].Value, out parseResult)) {
					if (parseResult <= 100) {
						return _statusGood;
					}
				}
			}
			return _statusBad;
		}

		private string CheckValidDns(string message) {
			Regex regex = new Regex(@"202.180.64.10");
			return regex.IsMatch(message) ? _statusGood : _statusBad;
		}
	}
}
