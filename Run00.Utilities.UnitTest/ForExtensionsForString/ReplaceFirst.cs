using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;

namespace Run00.Utilities.UnitTest.ForExtensionsForType
{
	[TestClass, CategorizeByConventionClass(typeof(ReplaceFirst))]
	public class ReplaceFirst
	{
		[TestMethod, CategorizeByConvention]
		public void WhenStringStartsInValue_ShouldReplaceValue()
		{
			//Arrange
			var original = "Hello World";
			var expected = "Hello ";

			//Act
			var result = original.ReplaceFirst("World", string.Empty);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenStringFollowsAValueAfterSameValue_ShouldReplaceValue()
		{
			//Arrange
			var original = "Hello World World";
			var expected = "Hello  World";

			//Act
			var result = original.ReplaceFirst("World", string.Empty);

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
			var result = original.ReplaceFirst("World", string.Empty);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenStringDoesNotHaveValue_ShouldReturnOriginal()
		{
			//Arrange
			var original = "Hello World";

			//Act
			var result = original.ReplaceFirst("Hahaha", string.Empty);

			//Assert
			Assert.AreEqual(original, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenStringHasValueInMiddle_ShouldOnlyReplaceMiddle()
		{
			//Arrange
			var original = "Hello World Again";
			var expected = "Hello Again";

			//Act
			var result = original.ReplaceFirst("World ", string.Empty);

			//Assert
			Assert.AreEqual(expected, result);
		}
	}
}
