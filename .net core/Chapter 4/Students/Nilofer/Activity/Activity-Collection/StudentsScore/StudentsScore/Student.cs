using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScore
{
    internal class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public int Score;

        public Student() { }

        public Student(int id, string name, int age, int score)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }

        public void DisplayStudents()
        {   
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Score : {Score}");
            Console.WriteLine();

        }
    }
}
