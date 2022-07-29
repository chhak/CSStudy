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
            students.Add(????????????????????????);
            students.Add(????????????????????????);
            students.Add(????????????????????????);
            students.Add(????????????????????????);
            students.Add(????????????????????????);

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
