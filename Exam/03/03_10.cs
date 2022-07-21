using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._03
{
    interface Buyer
    {
        public abstract void Buy();
    }

    interface Seller
    {
        public abstract void Sell();
    }

    class Customers : Buyer, Seller
    {
        public void Sell()
        {
            Console.WriteLine("판매하기");
        }

        public void Buy()
        {
            Console.WriteLine("구매하기");
        }
    }

    internal class _03_10
    {
        static void Main10(string[] args)
        {
            Buyer  buyer  = new Customers();
            Seller seller = new Customers();

            buyer.Buy();
            seller.Sell();
        }
    }
}
