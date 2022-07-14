using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/14
 * 이름 : 김철학
 * 내용 : 메서드 지역변수 실습하기 교재 p275
 * 
 * 전역변수(Global Variable)
 *  - 모든 메서드에서 참조할 수 있는 변수
 *  - 객체지향프로그래밍에서 전역변수는 멤버변수(속성) 이다.
 *  
 * 지역변수(Local Variable)
 *  - 특정 메서드에서 선언한 변수로 해당 메서드에서만 참조한다.
 *  - 해당 메서드가 끝나면 Stack에서 사라진다.(Pop)
 */
namespace Ch04
{
    internal class _4_메서드_지역변수
    {        
        static int result = 0; // 전역변수

        static void Main4(string[] args)
        {            
            int n1 = 1;  // 지역변수
            int n2 = 10; // 지역변수

            result = Sum(n1, n2);

            Console.WriteLine("result : " + result);

        }// end of Main

        public static int Sum(int start, int end)
        {
            result = 0;            
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }
            return total;
        }
    }
}
