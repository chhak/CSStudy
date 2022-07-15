using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_07
    {
		static void Main7(string[] args)
		{
			int total = 0;

			for (int k = 1; k <= 10; k++)
			{

				if (k % 2 == 0  ||  k % 3 == 0)
				{
					total += k;
				}
			}
			Console.WriteLine("1 ~ 10까지 2와 3배수의 정수의 합 : " + total);
		}
	}
}
