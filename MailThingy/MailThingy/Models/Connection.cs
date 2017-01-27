using System;
using MailThingy.Helpers;

namespace MailThingy.Models {
	public class Connection {
		public string Employee { get; set; }

		public string Username { get; set; }

		public DateTime Time { get; set; }

		public bool IsValid {
			get {
				var connection = this;
				return
					connection.Employee.IsNullOrWhiteSpace()
					|| connection.Time >= DateTime.Now
					|| connection.Username.IsNullOrWhiteSpace();
			}
		}
	}

}