using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_oops
{
    internal class Students
    {
        public string Name;
        public int RollNumber;
        public string Grade;

        public Students (string name, int rollNumber, string grade)
        {
            Name = name;
            RollNumber = rollNumber;
            Grade = grade;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Name:" + Name);
            Console.WriteLine("Roll Number:" + RollNumber);
            Console.WriteLine("Grade:" + Grade);
            Console.WriteLine();

        }
    }
}
 