using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_03
    {
		static void Main3(string[] args)
		{
			int x = 4;
			int y = -2;
			int z = 0;

			z = x + y;
			Console.WriteLine("x + y = " + z);

			z = x - y;
			Console.WriteLine("x - y = " + z);

			z = x * y;
			Console.WriteLine("x * y = " + z);

			z = x / y;
			Console.WriteLine("x / y = " + z);

			z = (x + y) * (x - y);
			Console.WriteLine("(x + y) * (x - y) = " + z);
		}
	}
}
