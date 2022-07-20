using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/20
 * 이름 : 김철학
 * 내용 : 구조체 실습하기 교재 p404
 * 
 * 구조체(Structure)
 *  - 간단하게 객체를 만들때 사용하는 구조형식
 *  - 클래스와 동일하지만 상속, 다형성 등 지원안함
 */
namespace Ch06
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Add()
        {
            return x + y;
        }
    }


    internal class _3_구조체
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 1;
            p1.y = 2;

            Console.WriteLine("p1 Add : " + p1.Add());

            Point p2 = new Point(2, 3);
            Console.WriteLine("p2 Add : " + p2.Add());
        }
    }
}
