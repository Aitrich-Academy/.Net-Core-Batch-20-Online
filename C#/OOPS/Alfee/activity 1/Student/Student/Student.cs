using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_oops
{
    internal class Student
    {
        public string Name;
        public int Age;
        public string Grade;

        public void DisplayDetails()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
