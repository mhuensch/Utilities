using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;
using System.Linq;

namespace Run00.Utilities.UnitTest.ForExtensionsForEnumerableOfT
{
	[TestClass, CategorizeByConventionClass(typeof(NextElement))]
	public class NextElement
	{
		[TestMethod, CategorizeByConvention]
		public void WhenEnumerableIsEmpty_ReturnsDefault()
		{
			//Arrange
			var list = Enumerable.Empty<string>();

			//Act
			var result = list.NextElement("hahah");

			//Assert
			Assert.AreEqual(default(string), result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenEnumerableHasItems_ReturnsNextItem()
		{
			//Arrange
			var previous = "Bob";
			var expected = "Joe";
			var list = new[] { "Michael", previous, expected };

			//Act
			var result = list.NextElement(previous);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenPreviousIsLastItem_ReturnsFirstItem()
		{
			//Arrange
			var previous = "Bob";
			var expected = "Joe";
			var list = new[] { expected, "Michael", previous };

			//Act
			var result = list.NextElement(previous);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenPreviousNotInList_ReturnsFirstItem()
		{
			//Arrange
			var previous = "Bob";
			var expected = "Joe";
			var list = new[] { expected, "Michael", "Jane" };

			//Act
			var result = list.NextElement(previous);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenPreviousIsNull_ReturnsFirstItem()
		{
			//Arrange
			var expected = "Joe";
			var list = new[] { expected, "Michael", "Jane" };

			//Act
			var result = list.NextElement(null);

			//Assert
			Assert.AreEqual(expected, result);
		}

	}
}
