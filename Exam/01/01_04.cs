using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_04
    {
		static void Main4(string[] args)
		{
			int num = 1;
			int result;

			result = num++;

			Console.WriteLine("result : " + result);

			result = ++num;
			Console.WriteLine("result : " + result);

			result = num--;
			Console.WriteLine("result : " + result);

			result = --num;
			Console.WriteLine("result : " + result);
		}
	}
}
