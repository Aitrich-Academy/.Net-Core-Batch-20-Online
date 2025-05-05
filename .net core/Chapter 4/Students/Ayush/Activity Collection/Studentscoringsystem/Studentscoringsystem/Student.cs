using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentscoringsystem
{
    public class Student
    {
        public string id;
        public string name;
        public int age;
        public int score;

        public Student() { }

        public Student(string id, string name, int age, int score)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.score = score;
        }

        public void displaystudents()
        {
            Console.WriteLine($"ID : {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
