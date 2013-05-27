using System.Text.RegularExpressions;

namespace Run00.Utilities
{
	public static class ExtensionsForString
	{
		/// <summary>
		/// Replaces the last occurrence of the string with the given value.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="lookFor">The string to look for.</param>
		/// <param name="replaceWith">The string to replace the lookfor with.</param>
		/// <returns></returns>
		public static string ReplaceLast(this string source, string lookFor, string replaceWith)
		{
			return new Regex(lookFor, RegexOptions.RightToLeft).Replace(source, replaceWith, 1);
		}

		/// <summary>
		/// Replaces the first occurrence of the string with the given value.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="lookFor">The string to look for.</param>
		/// <param name="replaceWith">The string to replace the lookfor with.</param>
		/// <returns></returns>
		public static string ReplaceFirst(this string source, string lookFor, string replaceWith)
		{
			return new Regex(lookFor).Replace(source, replaceWith, 1);
		}

		/// <summary>
		/// Strips any XML in the give string
		/// </summary>
		/// <param name="source">The source.</param>
		/// <returns></returns>
		public static string StripXml(this string source)
		{
			return Regex.Replace(source, @"<[^>]*>", string.Empty);
		}
	}
}