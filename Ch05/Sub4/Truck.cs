using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Truck : Car
    {
        private int capacity;

        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("트럭명 : " + name);
            Console.WriteLine("트럭색 : " + color);
            Console.WriteLine("트럭속도 : " + speed);
            Console.WriteLine("적재용량 : " + capacity);
            Console.WriteLine("-----------------");
        }
    }
}
