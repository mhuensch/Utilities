using System.Diagnostics.Contracts;
using System.Web.Mvc;

namespace Run00.WebUtilities
{
	public static class ExtensionsForHtmlHelper
	{
		/// <summary>
		/// Truncates the string to the length specified and appends "..."
		/// </summary>
		/// <param name="helper">The helper.</param>
		/// <param name="input">The original string.</param>
		/// <param name="length">The total desired length.</param>
		/// <returns></returns>
		public static string Truncate(this HtmlHelper helper, string input, int length)
		{
			Contract.Requires(length >= 0);

			if (input.Length <= length)
				return input;

			var replacement = " ...";
			if (replacement.Length > length)
				return replacement.Substring(replacement.Length - length, length);

			length = length - replacement.Length;
			length = length < 0 ? 0 : length;

			return input.Substring(0, length) + replacement;
		}
	}
}