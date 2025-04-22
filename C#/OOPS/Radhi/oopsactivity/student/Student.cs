using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Student
    {
        public string Name;
        public int Age;
        public string Grade;

        public Student(string name,int age,string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;

        }
        public void display()
        {
            Console.WriteLine($"Name:{Name} \nAge:{Age} \nGrade:{Grade}");

        }

    }
}
