using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoringSystem
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private double score;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public double Score { get { return score; } set { score = value; } }

        public Student() { }
        public Student (int id , string name , int age, double score)
        {
            Id = id;
            Name = name;
            Age = age;
            Score = score;
        }
    }
}
