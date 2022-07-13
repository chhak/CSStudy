using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/13
 * 이름 : 김철학
 * 내용 : 문자열 실습하기 교재 p112
 */
namespace Ch02
{
    internal class _6_문자열
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            // 문자열 길이
            Console.WriteLine("길이 : " + greeting.Length);
            Console.WriteLine();

            // 문자열 추출
            Console.WriteLine("greeting  1번째 문자 : " + greeting[0]);
            Console.WriteLine("greeting  6번째 문자 : " + greeting[5]);
            Console.WriteLine("greeting 12번째 문자 : " + greeting[11]);
            Console.WriteLine();

            // 문자열 인덱스
            Console.WriteLine("'G' 인덱스 : "+greeting.IndexOf('G'));
            Console.WriteLine("'M' 인덱스 : "+greeting.IndexOf('M'));
            Console.WriteLine("'o' 인덱스 : "+greeting.IndexOf('o'));     // 앞에서 부터
            Console.WriteLine("'o' 인덱스 : "+greeting.LastIndexOf('o')); // 뒤에서 부터
            Console.WriteLine();

            // 문자열 자르기
            Console.WriteLine("greeting 0~4 까지 문자열 : " + greeting.Substring(0, 4));
            Console.WriteLine("greeting 5~7 까지 문자열 : " + greeting.Substring(5, 7));
            Console.WriteLine("greeting 5~마지막까지 문자열 : " + greeting.Substring(5));
            Console.WriteLine();

            // 문자열 교체
            string replaced = greeting.Replace("Morning", "Afternoon");
            Console.WriteLine(replaced);
            Console.WriteLine();

            // 문자열 변환
            int    var1 = 1;
            double var2 = 2.123;
            bool   var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = ""+var3;

            Console.WriteLine("str1 : "+str1);
            Console.WriteLine("str2 : "+str2);
            Console.WriteLine("str3 : "+str3);
            Console.WriteLine();

            string s1 = "100";
            string s2 = "3.14";
            string s3 = "false";

            int    r1 = int.Parse(s1);
            double r2 = double.Parse(s2);
            bool   r3 = bool.Parse(s3);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
        }
    }
}
