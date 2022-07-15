using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _02_07
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            if (a == b && b == c)
            {                
                Console.WriteLine(10000 + a * 1000);
            }
            else if (a == b)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (b == c)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else if (c == a)
            {                
                Console.WriteLine(1000 + c * 100);
            }
            else
            {
                if (a > b && a > c)
                {
                    Console.WriteLine(a * 100);
                }
                else
                {
                    if (b > c)
                    {                        
                        Console.WriteLine(b * 100);
                    }
                    else
                    {
                        Console.WriteLine(c * 100);
                    }
                }
            }
        }
    }
}
