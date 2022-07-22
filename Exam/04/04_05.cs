using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._04
{
	class TV
	{
		public string Show()
		{
			return "TV 입니다.";
		}
	}
	class Computer
	{
		public string Show()
		{
			return "Computer 입니다.";
		}
	}

	class Product<T1, T2>
	{
		private T1 item;
		private T2 info;

		public Product(T1 item, T2 info)
		{
			this.item = item;
			this.info = info;
		}

		public T1 Item { get { return item; } }
		public T2 Info { get { return info; } }
	}

	internal class _04_05
	{
		static void Main5(string[] args)
		{
			TV tv = new TV();
			Computer com = new Computer();

			Product<TV, int> item1 = new Product<TV, int>(tv, 55);
			Console.WriteLine(item1.Item.Show());
			Console.WriteLine("TV 인치 : " + item1.Info);
			Console.WriteLine();

			Product<Computer, string> item2 = new Product<Computer, string>(com, "Apple");
			Console.WriteLine(item2.Item.Show());
			Console.WriteLine("Computer 제조사 : " + item2.Info);
		}
	}
}
