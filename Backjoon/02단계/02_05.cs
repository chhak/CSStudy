using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _02_05
    {
        static void Main5(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int h = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);


            if (m >= 0 && m < 45)
            {
                h -= 1;
                m += 15;

                if (h < 0)
                {
                    h = 23;
                }

                Console.WriteLine("{0} {1}", h, m);
            }
            else
            {                                
                m -= 45;
                Console.WriteLine("{0} {1}", h, m);
            }            
        }
    }
}
