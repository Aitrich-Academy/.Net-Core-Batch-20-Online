using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificElements
{
    internal class Student
    {
        public Student() { }
        public string Name { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }

        public Student(string name, int score, int id)
        {
            Name = name;
            Score = score;
            Id = id;
        }
    }
}
