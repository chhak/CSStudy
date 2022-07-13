using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/13
 * 이름 : 김철학
 * 내용 : 배열 실습하기 교재 p157
 */
namespace Ch03
{
    internal class _5_배열
    {
        static void Main(string[] args)
        {
            // 배열
            int[] arr1 = new int[3];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            int[] arr2 = { 1, 2, 3, 4, 5 };
            string[] arr3 = { "서울", "대전", "대구", "부산", "광주" };

            // 배열 원소 출력
            Console.WriteLine("arr1의 1번째 원소 : " + arr1[0]);
            Console.WriteLine("arr2의 3번째 원소 : " + arr2[2]);
            Console.WriteLine("arr3의 4번째 원소 : " + arr3[3]);

            // 배열 길이
            Console.WriteLine("arr1 배열 길이 : " + arr1.Length);
            Console.WriteLine("arr2 배열 길이 : " + arr2.Length);
            Console.WriteLine("arr3 배열 길이 : " + arr3.Length);

            // 배열 반복문
            for (int i=0; i<arr1.Length; i++)
            {
                Console.WriteLine("arr1[{0}] : {1}", i, arr1[i]);
            }

            foreach (int num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            foreach (string city in arr3)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();

            // 1차원 배열
            // 2차원 배열
            // 3차원 배열                
        }
    }
}
