using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _02_01
    {
        static void Main1(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);   
            int b = int.Parse(inputs[1]);   

            if (a > b)
            {
                Console.WriteLine(">");
            }

            if (a < b)
            {
                Console.WriteLine("<");
            }

            if (a == b)
            {
                Console.WriteLine("==");
            }

        }
    }
}
