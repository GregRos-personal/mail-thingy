using System;
using System.Collections.Generic;

namespace MailThingy.Models {
	public static class DepositKinds {
		public static IEnumerable<Tuple<DepositKind, string>> Kinds() {
			return new[] {
				Tuple.Create(DepositKind.BankTransfer, "Bank Transfer"),
				Tuple.Create(DepositKind.CreditCard, "Credit Card"),
				Tuple.Create(DepositKind.Other, "Other")
			};
		}
	}
}