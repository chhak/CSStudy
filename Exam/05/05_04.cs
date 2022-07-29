using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
    internal class _05_04
    {
		static void Main4(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				SortedSet<int> set = MakeLotto();

				foreach (int n in set)
				{
					Console.Write(n + " ");
				}
				Console.WriteLine();
			}
		}

		public static SortedSet<int> MakeLotto()
		{
			SortedSet<int> set = new SortedSet<int>();
			Random random = new Random();

			for (; ; )
			{
				int num = random.Next(1, 46);

				set.Add(num);

				if (set.Count == 6)
				{
					break;
				}
			}

			return set;
		}
	}
}
