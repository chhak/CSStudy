using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 0000/00/00
 * 이름 : 김철학
 * 내용 : 스트림 연습문제
 * 
 * 객체의 직렬화
 *  - 객체를 스트림을 통해 외부 파일로 생성하기 위한 작업이다.
 *  - 스트림으로 전송될 객체는 Serializable 어트리뷰트를 선언한다.
 *  - 외부의 객체파일을 다시 객체로 복원하는 것을 역직렬화라고 한다.
 */
namespace Exam._05
{
	[Serializable]
	class Orange
	{
		private string country;
		private int price;

		public Orange(string country, int price)
		{
			this.country = country;
			this.price = price;
		}

		public void Show()
		{
			Console.WriteLine("원산지 : " + country);
			Console.WriteLine("가격 : " + price);
		}
	}

	internal class _05_06
	{
		static void Main6(string[] args)
		{
			string path = "C:\\Users\\1302\\Desktop\\Orange.dat";

			// 직렬화
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				BinaryFormatter serializer = new BinaryFormatter();

				Orange orange = new Orange("캘리포니아", 5000);
				serializer.Serialize(fs, orange);
			}

			// 역직렬화
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				BinaryFormatter deserializer = new BinaryFormatter();

				Orange orange = (Orange)deserializer.Deserialize(fs);
				orange.Show();
			}
		}
	}
}
