using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._02
{
    internal class _02_09
    {
		static void Main9(string[] args)
		{
			Console.WriteLine("3! = " + factorial(3));
			Console.WriteLine("4! = " + factorial(4));
			Console.WriteLine("5! = " + factorial(5));
		}

		public static int factorial(int n)
		{
			if (n <= 1)
			{
				return 1;
			}

			return n * factorial(n-1);
		}
	}
}
