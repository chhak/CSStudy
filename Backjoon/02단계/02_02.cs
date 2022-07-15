using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _02_02
    {
        static void Main2(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
