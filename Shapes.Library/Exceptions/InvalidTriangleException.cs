using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Exceptions
{
	public class InvalidTriangleException : Exception
	{
		public InvalidTriangleException(string message) : base(message)
		{

		}
	}
}
