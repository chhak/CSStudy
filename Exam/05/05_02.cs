using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{
	class NotFoundException : Exception
	{
		public NotFoundException() : base("해당하는 숫자를 찾을 수 없습니다.") { }
	}

	internal class _05_02
	{
		static void Main2(string[] args)
		{
			int[] arr = { 2, 4, 6, 8, 10 };

			Console.Write("찾을 숫자 입력 : ");

			try
			{
				int find = Convert.ToInt32(Console.ReadLine());

				searchArray(find, arr);
				Console.WriteLine("해당하는 숫자 찾음!!!");

			}
			catch (NotFoundException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.WriteLine("프로그램 정상 종료...");
		}

		public static void searchArray(int find, int[] arr)
		{

			foreach (int i in arr)
			{
				if (i == find)
				{
					return;
				}
			}

			throw new NotFoundException();
		}
	}
}
