using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/26
 * 이름 : 김철학
 * 내용 : 예외 던지기 실습하기 교재 p479
 */
namespace Ch08
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                // 예외 던지기(예외 강제 발생)
                throw new Exception("크기는 0보다 작을 수 없습니다.");
            }
        }

        public void Area()
        {
            Console.WriteLine("Box 넓이 : " + width * height);
        }
    }

    internal class _2_예외_던지기
    {
        static void Main2(string[] args)
        {
            try
            {
                Box box1 = new Box(10, 10);
                box1.Area();

                Box box2 = new Box(-10, -10);
                box2.Area();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
