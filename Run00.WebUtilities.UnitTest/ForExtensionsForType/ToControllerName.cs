using Microsoft.VisualStudio.TestTools.UnitTesting;
using Run00.MsTest;
using Run00.Utilities.Web.UnitTest.Artifacts;

namespace Run00.Utilities.Web.UnitTest.ForExtensionsForType
{
	[TestClass, CategorizeByConventionClass(typeof(ToControllerName))]
	public class ToControllerName
	{
		[TestMethod, CategorizeByConvention]
		public void WhenNameEndsWithController_ShouldRemoveController()
		{
			//Arrange
			var type = typeof(TestController);

			//Act
			var result = type.ToControllerName();

			//Assert
			Assert.AreEqual("Test", result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenNameStartsWithController_ShouldNotRemoveController()
		{
			//Arrange
			var type = typeof(ControllerTest);

			//Act
			var result = type.ToControllerName();

			//Assert
			Assert.AreEqual("ControllerTest", result);
		}

		[TestMethod, CategorizeByConvention]
		public void WhenNameIsOnlyController_ShouldNotRemoveController()
		{
			//Arrange
			var type = typeof(Controller);

			//Act
			var result = type.ToControllerName();

			//Assert
			Assert.AreEqual("Controller", result);
		}
	}
}
