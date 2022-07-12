using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/12
 * 이름 : 김철학
 * 내용 : 연산자 실습하기 교재 p90
 * 
 * 연산자(Operator)
 *  - 변수에 저장된 데이터를 가공하기 위해 연산자를 사용
 *  - 연산자는 크게 산술, 증감, 복합대입, 비교, 논리 연산자 등이 있다.
 */
namespace Ch02
{
    internal class _3_연산자
    {
        static void Main3(string[] args)
        {
            // 산술 연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int r1 = num1 + num2;
            int r2 = num1 - num2;
            int r3 = num2 * num3;
            int r4 = num4 / num2;
            int r5 = num4 % num3; // 나머지

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);
            Console.WriteLine("r5 : "+r5);

            // 증감 연산자
            int num = 0;

            num++;
            ++num;

            Console.WriteLine($"num : {num}"); // 문자열 보간

            num--;
            --num;

            Console.WriteLine($"num : {num}");

            // 복합대입 연산자
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;

            n1 += 1; // n1 = n1 + 1
            n2 -= 2; // n2 = n2 - 2
            n3 *= 3; // n3 = n3 * 3
            n4 /= 4; // n4 = n4 / 4

            Console.WriteLine($"n1 : {n1}");
            Console.WriteLine($"n2 : {n2}");
            Console.WriteLine($"n3 : {n3}");
            Console.WriteLine($"n4 : {n4}");

            // 비교 연산자
            int var1 = 1;
            int var2 = 2;

            bool rs1 = var1 > var2;     // var1이 var2보다 크다.
            bool rs2 = var1 < var2;     // var1이 var2보다 작다.
            bool rs3 = var1 >= var2;    // var1이 var2보다 크거나 같다.
            bool rs4 = var1 <= var2;    // var1이 var2보다 작거나 같다.
            bool rs5 = var1 == var2;    // var1이 var2보다 서로 같다.
            bool rs6 = var1 != var2;    // var1이 var2보다 서로 다르다.

            Console.WriteLine($"rs1 : {rs1}");
            Console.WriteLine($"rs2 : {rs2}");
            Console.WriteLine($"rs3 : {rs3}");
            Console.WriteLine($"rs4 : {rs4}");
            Console.WriteLine($"rs5 : {rs5}");
            Console.WriteLine($"rs6 : {rs6}");

            // 논리 연산자
            bool res1 = var1 > 1 && var2 > 2; // var1은 1보다 크고 그리고 var2는 2보다 크다.
            bool res2 = var1 > 0 && var2 > 1; // var1은 0보다 크고 그리고 var2는 1보다 크다.
            bool res3 = var1 > 1 || var2 > 2; // var1은 1보다 크고 또는 var2는 2보다 크다.
            bool res4 = var1 > 0 || var2 > 2; // var1은 0보다 크고 또는 var2는 2보다 크다.
            bool res5 = !(var1 > var2);       // var1은 var2보다 크지 않다.

            Console.WriteLine($"res1 : {res1}");
            Console.WriteLine($"res2 : {res2}");
            Console.WriteLine($"res3 : {res3}");
            Console.WriteLine($"res4 : {res4}");
            Console.WriteLine($"res5 : {res5}");

            // 조건 연산자
            int number = 1;
            string result = (number > 1) ? "number가 1보다 크다." : "number가 1보다 작다.";
            Console.WriteLine($"result : {result}");
        }
    }
}
