using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoreSorting
{
    internal class Student
    {
        public int Id;
        public string Name;
        public int Score;

        public Student(int id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }

        public Student() { }

        public void Display()
        {
            Console.WriteLine($"Id : {Id}   Name : {Name}  Score : {Score}");
        }
    }
}
