using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1
{
    public class Student
    {
        public int score;
        public string name;

        public Student() { }

        public Student(int score, string name)
        {
            this.score = score;
            this.name = name;
        }
    }

    public class Employee
    {
        public string Name;
        public int year;

        public Employee() { }

        public Employee(string Name, int year)
        {
            this.Name = Name;
            this.year = year;
        }
    }
}
