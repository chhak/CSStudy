using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/13
 * 이름 : 김철학
 * 내용 : 조건문 if 실습하기 교재 p127
 */
namespace Ch03
{
    internal class _1_If문
    {
        static void Main1(string[] args)
        {
            // if
            int num1 = 1;
            int num2 = 2;

            if ( num1 < num2 )
            {
                // 조건이 참이면 실행
                Console.WriteLine("num1이 num2보다 작다.");
            }

            if ( num1 < 0 )
            {
                Console.WriteLine("num1은 0보다 작다.");
            }

            if (num1 > 0)
            {
                if (num2 > 1)
                {
                    Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다.");
                }
            }

            if ( num1 > 0 && num2 > 1 )
            {
                Console.WriteLine("num1은 0보다 크고 그리고 num2는 1보다 크다.");
            }

            // if ~ else
            int var1 = 1, var2 = 2;

            if (var1 > var2)
            {
                // 조건이 참 일때
                Console.WriteLine("var1이 var2보다 크다.");
            }
            else
            {
                // 조건이 거짓 일때
                Console.WriteLine("var1이 var2보다 작다.");
            }

            // if ~ else if ~ else
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            if (n1 > n2)
            {
                Console.WriteLine("n1이 n2보다 크다.");
            }
            else if (n2 > n3)
            {
                Console.WriteLine("n2이 n3보다 크다.");
            }
            else if (n3 > n4)
            {
                Console.WriteLine("n3이 n4보다 크다.");
            }
            else
            {
                Console.WriteLine("n4가 가장 크다.");
            }
        }
    }
}
