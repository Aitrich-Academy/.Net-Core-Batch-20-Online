using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Details
{
    internal class Student
    {
        public string Name;
        public int RollNumber;
        public string Grade;

        public Student(string name, int rollNumber, string grade)
        {
            Name = name;
            RollNumber = rollNumber;
            Grade = grade;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine();
        }
    }
}
