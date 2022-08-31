using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Library.Exceptions;
using Shapes.Library.Shapes;

namespace Shapes.Tests
{
	[TestClass]
	public class TriangleTest
	{
		[TestMethod]
		[ExpectedException(typeof(InvalidTriangleException))]
		public void TestWrongTriangle()
		{
			var triangle = new Triangle(5, -1, 2);
		}

		[TestMethod]
		public void TestCorrectTriangleArea()
		{
			double correctArea = 6;

			var triangle = new Triangle(3, 4, 5);
			var actual = triangle.CalculateArea();

			Assert.AreEqual(correctArea, actual);
		}

		[TestMethod]
		public void TestWrongTriangleArea()
		{
			double wrongArea = 5.9;

			var triangle = new Triangle(3, 4, 5);
			var actual = triangle.CalculateArea();

			Assert.AreNotEqual(wrongArea, actual);
		}

		[TestMethod]
		public void TestRightTriangle()
		{
			var correctAnswer = true;

			var triangle = new Triangle(3, 4, 5);

			Assert.AreEqual(correctAnswer, triangle.IsRightTriangle());
		}
	}
}
