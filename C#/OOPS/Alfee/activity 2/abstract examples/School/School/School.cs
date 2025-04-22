using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_oops
{
    abstract class School
    {
        public string Name;
        public int Age;

        public School(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void GetRole();

        public void ShowDetails()
        {
            Console.WriteLine("Name of the person is :" + Name);
            Console.WriteLine("Age of the person is :" + Age);
        }
    }

    class Student : School
    {
        public Student(string name, int age) : base(name, age) { }

        public override void GetRole()
        {
            Console.WriteLine("I am a student.");
        }
    }

    class Teacher : School
    {
        public Teacher(string name, int age) : base(name, age) { }

        public override void GetRole()
        {
            Console.WriteLine("I am a teacher.");
        }
    }

}
