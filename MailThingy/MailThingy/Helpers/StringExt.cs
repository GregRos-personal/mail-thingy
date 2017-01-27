namespace MailThingy.Helpers {
	internal static class StringExt {
		public static bool IsNullOrWhiteSpace(this string what) {
			return string.IsNullOrWhiteSpace(what);
		}
	}
}