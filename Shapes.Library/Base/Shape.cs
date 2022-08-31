using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Base
{
	public abstract class Shape
	{
		public abstract override string ToString();
		public abstract double CalculateArea();
	}
}
