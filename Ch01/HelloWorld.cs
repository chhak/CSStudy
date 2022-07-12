using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022년 07월 12일
 * 이름 : 김철학
 * 내용 : C# 개발환경 설정, Hello World 출력 교재 p44
 */
namespace Ch01
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            // 기본출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#!");

            // 서식출력
            Console.Write("Hello\t");
            Console.Write("Korea\n");

            // 포맷출력
            Console.WriteLine("{0}, {1}", "Hello", "Busan");
        }
    }
}
