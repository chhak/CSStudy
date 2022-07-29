using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11
{
    class User
    {
        private string uid;
        private string name;
        private string hp;
        private int age;

        public User(string uid, string name, string hp, int age)
        {
            this.uid = uid;
            this.name = name;
            this.hp = hp;
            this.age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Hp { get => hp; set => hp = value; }
        public int Age { get => age; set => age = value; }
    }
}
