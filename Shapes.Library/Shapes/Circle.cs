using Shapes.Library.Base;
using Shapes.Library.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Shapes
{
	public class Circle : Shape
	{
		private readonly double _radius;
		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new InvalidCircleException("Invalid radius");
			}

			_radius = radius;
		}
		public override double CalculateArea()
		{
			var area = Math.PI * Math.Pow(_radius, 2);

			return area;
		}

		public override string ToString()
		{
			return $"Circle - { _radius }";
		}
	}
}
