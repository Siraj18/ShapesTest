using Shapes.Library.Base;
using Shapes.Library.Shapes;
using System;
using System.Collections.Generic;

namespace Shapes.Preview
{
	// Неизвестная фигура
	class UnknownShape : Shape
	{
		private readonly double _side;
		public UnknownShape(double side)
		{
			_side = side;
		}
		public override double CalculateArea()
		{
			return _side * _side;
		}

		public override string ToString()
		{
			return $"Unknown shape - {_side}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			Circle circle = new Circle(5);
			Triangle triangle = new Triangle(3, 4, 5);
			UnknownShape unknownShape = new UnknownShape(4);

			List<Shape> shapes = new List<Shape>() { circle, triangle, unknownShape };

			foreach (Shape shape in shapes)
			{
				Console.WriteLine("Shape: " + shape.ToString());
				Console.WriteLine("Area: " + shape.CalculateArea());

				Console.WriteLine();
			}
		}
	}
}
