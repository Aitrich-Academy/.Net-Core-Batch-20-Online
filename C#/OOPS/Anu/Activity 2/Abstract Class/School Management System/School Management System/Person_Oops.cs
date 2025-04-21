using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{ 
        abstract class Person
        {

            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public abstract void GetRole();

            public void ShowDetails()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            } 
        }

        class Student : Person
        {
            public Student(string name, int age) : base(name, age) { }

            public override void GetRole()
            {
                Console.WriteLine("I am a student.");
            }
        }

        class Teacher : Person
        {
            public Teacher(string name, int age) : base(name, age) { }

            public override void GetRole()
            {
                Console.WriteLine("I am a teacher.");
            }
        }

    }

