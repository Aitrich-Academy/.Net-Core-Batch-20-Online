using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinStudentEnrollment
{
    internal class Student
    {
        public int StudId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int sid,string name, int age)
        {
            StudId = sid;
            Name = name;
            Age = age;

        }
        public Student() { }
    }
}
