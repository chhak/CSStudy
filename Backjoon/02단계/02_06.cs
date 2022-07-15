using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _02_06
    {
        static void Main6(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(Console.ReadLine());


            int tot = b + c;

            if (tot >= 60)
            {
                int h = tot / 60;
                int m = tot % 60;

                a += h;

                if (a >= 24)
                {
                    a %= 24;
                }

                Console.WriteLine("{0} {1}", a, m);

            }
            else
            {                
                Console.WriteLine("{0} {1}", a, tot);
            }           
        }
    }
}
