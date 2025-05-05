using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQActivity2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(string name, int age , int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
