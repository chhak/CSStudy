using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/12
 * 이름 : 김철학
 * 내용 : 변수 실습하기 교재 p79
 * 
 * 변수(Variable)
 *  - 데이터를 처리하기 위한 데이터 그릇
 *  - 변수는 메모리상에 생성되는 공간
 * 
 * 상수(Constant)
 *  - 데이터를 변경할 수 없는 변수
 *  - 최초 저장(초기화)된 데이터를 고정
 */
namespace Ch02
{
    internal class _1_변수
    {
        static void Main1(string[] args)
        {
            /////////////////////////////////
            //변수
            /////////////////////////////////
            
            // 선언
            int num1;
            // 값 할당
            num1 = 1;

            // 선언과 초기화
            int num2 = 2;

            // 데이터 처리(연산)
            int num3 = num1 + num2; 

            // 결과확인
            Console.WriteLine("num1 : "+num1);
            Console.WriteLine("num2 : "+num2);
            Console.WriteLine("num3 : "+num3);

            /////////////////////////////////
            //상수
            /////////////////////////////////
            const double PI = 3.14;
            const int NUM = 10;
            //NUM = 20; <-- 상수는 값 변경 X

            Console.WriteLine("PI : " + PI);
            Console.WriteLine("NUM : " + NUM);
        }
    }
}
