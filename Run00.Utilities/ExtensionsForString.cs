using System.Text.RegularExpressions;

namespace Run00.Utilities
{
	public static class ExtensionsForString
	{
		/// <summary>
		/// Replaces the last occurrence of the string with the given value.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="lookFor">The look for.</param>
		/// <param name="replaceWith">The replace with.</param>
		/// <returns></returns>
		public static string ReplaceLast(this string source, string lookFor, string replaceWith)
		{
			var index = source.LastIndexOf(lookFor);
			var length = index == -1 ? source.Length : index;
			return source.Substring(0, length);
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