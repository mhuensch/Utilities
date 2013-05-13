using System;
using System.Web.Mvc;

namespace Run00.Utilities.Web
{
	public static class ExtensionsForType
	{
		/// <summary>
		/// Replaces the last occurrence of the word "Controller" in the Type.Name  for MVC controllers
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static string ToControllerName(this Type type)
		{
			if (typeof(Controller).IsAssignableFrom(type) == false)
				return type.Name;

			if (type.Name.EndsWith("Controller", StringComparison.InvariantCulture) == false)
				return type.Name;

			if (type.Name.Equals("Controller", StringComparison.InvariantCulture))
				return type.Name;

			return type.Name.ReplaceLast("Controller", string.Empty);
		}
	}
}