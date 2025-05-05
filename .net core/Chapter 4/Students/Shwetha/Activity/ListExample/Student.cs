using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Student
    {
        private int id;
        private string name;
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {

        }
        public Student (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
