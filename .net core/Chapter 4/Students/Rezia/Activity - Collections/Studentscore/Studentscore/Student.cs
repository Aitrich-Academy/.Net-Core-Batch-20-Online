using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentscore
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }

        public Student() { }

        public Student(int id, string name, int age, double score)
        {
            Id = id;
            Name = name;
            Age = age;
            Score = score;
        }
        public override string ToString()
        {
            Console.WriteLine("********************************");
            Console.WriteLine($"Student ID : {Id}");
            Console.WriteLine($"Student name : {Name}");
            Console.WriteLine($"Student Age : {Age}");
            Console.WriteLine($"Student Score : {Score}");
            Console.WriteLine("**********************************");

            return string.Empty;
        }
        }
    }

