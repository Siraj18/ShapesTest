using Shapes.Library.Base;
using Shapes.Library.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Shapes
{
	public class Triangle : Shape
	{
		private readonly double[] _sides;
		public Triangle(double a, double b, double c)
		{
			var existCondition1 = a < b + c;
			var existCondition2 = b < a + c;
			var existCondition3 = c < a + b;
			var existCondition4 = a > 0 && b > 0 && c > 0;

			if (!(existCondition1 && existCondition2 && existCondition3 && existCondition4))
			{
				throw new InvalidTriangleException("Invalid triangle sides");
			}

			_sides = new double[] { a, b, c };
		}
		public override double CalculateArea()
		{
			var p = (_sides[0] + _sides[1] + _sides[2]) / 2; // Вычисление полупериметра


			var area = Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
			return area;
		}

		public override string ToString()
		{
			return $"Triangle - { _sides[0] }, { _sides[1] }, { _sides[2] }";
		}

		public bool IsRightTriangle()
		{
			if ((_sides[0] * _sides[0] + _sides[1] * _sides[1] == _sides[2] * _sides[2]) ||
				(_sides[0] * _sides[0] + _sides[2] * _sides[2] == _sides[1] * _sides[1]) ||
				(_sides[2] * _sides[2] + _sides[1] * _sides[1] == _sides[0] * _sides[0]))
			{
				return true;
			}

			return false;
		}
	}
}
