using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQActivity
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student() { }
        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

    }
}
