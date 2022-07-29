using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    class Student
    {
        private string name;
        private int age;
        private int score;

        public Student(string name, int age, int score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Score { get => score; set => score = value; }
    }

    internal class _06_06
    {
        static void Main6(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("김유신", 25, 86));
            students.Add(new Student("김춘추", 23, 76));
            students.Add(new Student("장보고", 35, 88));
            students.Add(new Student("강감찬", 45, 62));
            students.Add(new Student("이순신", 55, 96));

            var result = from student in students
                         orderby student.Score descending
                         group student by student.Score >= 80 into g
                         select new
                         {
                             GroupKey = g.Key,
                             Groups = g
                         };

            foreach (var group in result)
            {
                Console.WriteLine();
                Console.WriteLine("80점 이상 : " + group.GroupKey);

                foreach (var student in group.Groups)
                {
                    Console.WriteLine("{0}, {1}, {2}", student.Name,
                                                       student.Age,
                                                       student.Score);
                }
            }
        }
    }
}
