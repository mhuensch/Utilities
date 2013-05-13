using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;
using System.Web.Mvc;

namespace Run00.WebUtilities.UnitTest.ForExtensionsForHtmlHelper
{
	[TestClass, CategorizeByConventionClass(typeof(Truncate))]
	public class Truncate
	{
		[TestMethod, CategorizeByConvention]
		public void WhenGivenLongString_ShouldReturnShortened()
		{
			//Arrange
			var helper = new HtmlHelper(new ViewContext(), new ViewPage());
			var original = "Hello World!";
			var expected = "Hello ...";

			//Act
			var result = helper.Truncate(original, 9);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenGivenShortString_ShouldReturnOriginal()
		{
			//Arrange
			var helper = new HtmlHelper(new ViewContext(), new ViewPage());
			var original = "Hello World!";

			//Act
			var result = helper.Truncate(original, 25);

			//Assert
			Assert.AreEqual(original, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenGivenLengthLessThanReplacement_ShouldReturnReplacement()
		{
			//Arrange
			var helper = new HtmlHelper(new ViewContext(), new ViewPage());
			var original = "Hello World!";

			//Act
			var result = helper.Truncate(original, 2);

			//Assert
			Assert.AreEqual("..", result);
		}

	}
}
