using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/26
 * 이름 : 김철학
 * 내용 : 대리자 실습하기 교재 p493
 * 
 * 대리자(Delegate)
 *  - 대리자는 메서드에 대한 참조를 하기 위한 구문으로 메서드를 대신 호출 해주는 역할
 *  - 대리자를 익명함수로 많이 사용(최신 프로그래밍에서는 람다식으로 대체)
 */
namespace Ch09
{
    // 대리자 선언
    public delegate int MyDelegate(int x, int y);
    public delegate int SumDelegate(int[] arr);

    internal class _1_대리자
    {
        static void Main1(string[] args)
        {
            // 대리자 초기화
            MyDelegate my1 = new MyDelegate(Plus);
            MyDelegate my2 = new MyDelegate(Minus);

            // 대리자 실행
            int r1 = my1(1, 2);
            int r2 = my2(1, 2);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);

            // 대리자 활용 : 메서드의 매개변수로 대리자 선언
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int rs1 = Sum(arr, OddSum);
            int rs2 = Sum(arr, EvenSum);

            Console.WriteLine("홀수합 : " + rs1);
            Console.WriteLine("짝수합 : " + rs2);

            // 대리자 활용 : 익명 메서드로 활용
            var function = delegate (int x, int y)
            {
                return x + y;
            };

            int res1 = function(1, 2);
            int res2 = function(2, 3);

            Console.WriteLine("res1 : " + res1);
            Console.WriteLine("res2 : " + res2);

            // 익명함수를 매개변수로 갖는 컬렉션 메서드
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myList.ForEach(delegate (int n)
            {
                Console.Write(n + " ");
            });
            Console.WriteLine();

            foreach (int n in myList)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

        }// Main end

        public static int Plus(int x, int y)
        {
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            return x - y;
        }

        public static int OddSum(int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                if (n % 2 == 1)
                {
                    sum += n;
                }
            }
            return sum;
        }

        public static int EvenSum(int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }

        public static int Sum(int[] arr, SumDelegate sd)
        {
            return sd(arr);
        }

    }
}
