using System;
using MailThingy.Helpers;

namespace MailThingy.Models {
	public class Deposit {
		public string Employee { get; set; }

		public string Username { get; set; }

		public decimal Amount { get; set; }

		public DepositKind Kind { get; set; }

		public DateTime Time { get; set; }

		public bool IsValid {
			get {
				var deposit = this;
				return !(
					deposit.Employee.IsNullOrWhiteSpace()
					|| deposit.Time > DateTime.Now
					|| deposit.Username.IsNullOrWhiteSpace()
					|| deposit.Kind > DepositKind.Other
					|| deposit.Kind < 0);
			}
		}

	}
}