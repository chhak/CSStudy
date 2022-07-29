using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    public delegate bool MyDelegate(int a);

    internal class _06_03
    {
        static void Main3(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int n1 = Count(arr, IsOdd);
            int n2 = Count(arr, IsEven);

            Console.WriteLine("홀수 갯수 : " + n1);
            Console.WriteLine("짝수 갯수 : " + n2);
        }

        public static int Count(int[] arr, ????????????????????????)
        {
            int cnt = 0;

            foreach (int n in arr)
            {
                if (my(n) == true)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public static ?????? IsOdd(int n)
        {
            return n % 2 != 0;
        }

        public static ?????? IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
