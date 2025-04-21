using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
   public class Student:Person
    {

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override void GetRole()
        {
            Console.WriteLine("I am Student");
        }
        

    }
}
