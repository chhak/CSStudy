using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._01
{
    internal class _01_05
    {
		static void Main5(string[] args)
		{
			string strScore = "60,72,82,86,92";
			string[] scores = strScore.Split(",");

			int total = 0;

			for (int i = 0; i < scores.Length; i++)
			{
				total += int.Parse(scores[i]);
			}

			Console.WriteLine("총점 : " + total);
		}
	}
}
