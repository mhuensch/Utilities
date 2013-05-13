using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;

namespace Run00.Utilities.UnitTest.ForExtensionsForType
{
	[TestClass, CategorizeByConventionClass(typeof(ReplaceLast))]
	public class ReplaceLast
	{
		[TestMethod, CategorizeByConvention]
		public void WhenStringEndsInValue_ShouldReplaceValue()
		{
			//Arrange
			var original = "Hello World";
			var expected = "Hello ";

			//Act
			var result = original.ReplaceLast("World", string.Empty);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenStringEndsInValueAfterSameValue_ShouldReplaceEndValue()
		{
			//Arrange
			var original = "Hello World World";
			var expected = "Hello World ";

			//Act
			var result = original.ReplaceLast("World", string.Empty);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenStringIsValue_ShouldReturnEmpty()
		{
			//Arrange
			var original = "World";
			var expected = string.Empty;

			//Act
			var result = original.ReplaceLast("World", string.Empty);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenStringDoesNotHaveValue_ShouldReturnOriginal()
		{
			//Arrange
			var original = "Hello World";

			//Act
			var result = original.ReplaceLast("Hahaha", string.Empty);

			//Assert
			Assert.AreEqual(original, result);
		}
	}
}
