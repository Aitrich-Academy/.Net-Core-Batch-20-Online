using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqActivity
{
    internal class Student
    {
        public int Id;
        public string Name;

        public Student() { }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
    }
}
