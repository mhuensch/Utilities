using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;
using Run00.Utilities.UnitTest.Artifacts;
using System.Linq;

namespace Run00.Utilities.UnitTest.ForExtensionsForEnumerableOfT
{
	[TestClass, CategorizeByConventionClass(typeof(Random))]
	public class Random
	{
		[TestMethod, CategorizeByConvention]
		public void WhenEnumerableIsEmpty_ReturnsDefault()
		{
			//Arrange
			var list = Enumerable.Empty<string>();

			//Act
			var result = list.Random();

			//Assert
			Assert.AreEqual(default(string), result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenEnumerableHasItems_ReturnsItemInEnumerable()
		{
			//Arrange
			var list = new [] {"Michael", "Bob", "Joe"};

			//Act
			var result = list.Random();

			//Assert
			Assert.IsTrue(list.Contains(result));
		}
		
	}
}
