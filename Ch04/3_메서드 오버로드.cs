using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김철학
 * 내용 : 메서드 오버로드 실습하기 교재 p275
 * 
 * 메서드 오버로드(Overload)
 *  - 같은 이름을 가진 메서드를 매개변수(Parameter)로 구분한 메서드
 *  - 메서드 반환값은 오버로드 메서드에 영향을 미치지 않음
 */
namespace Ch04
{
    internal class _3_메서드_오버로드
    {
        static void Main3(string[] args)
        {
            int    r1 = Plus(1, 2);
            int    r2 = Plus(1, 2, 3);
            double r3 = Plus(1.1, 2.2);
            string r4 = Plus("Hello", "World");

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);
            Console.WriteLine("r4 : " + r4);

        } // end of Main

        public static int Plus(int a, int b) 
        {
            return a + b;
        }
        public static int Plus(int a, int b, int c) 
        {
            return a + b + c;
        }
        public static double Plus(double a, double b) 
        {
            return a + b;
        }
        public static string Plus(string a, string b) 
        {
            return a + b;
        }
    }
}
