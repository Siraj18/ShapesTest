using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Library.Exceptions;
using Shapes.Library.Shapes;

namespace Shapes.Tests
{
	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		[ExpectedException(typeof(InvalidCircleException))]
		public void TestWrongCircle()
		{
			var circle = new Circle(-3);
		}

		[TestMethod]
		public void TestCorrectCircleArea()
		{
			double correctArea = 113.09733552923255;

			var circle = new Circle(6);
			var actual = circle.CalculateArea();

			Assert.AreEqual(correctArea, actual);
		}

		[TestMethod]
		public void TestWrongTriangleArea()
		{
			double wrongArea = 78;

			var circle = new Circle(5);
			var actual = circle.CalculateArea();

			Assert.AreNotEqual(wrongArea, actual);
		}
	}
}
