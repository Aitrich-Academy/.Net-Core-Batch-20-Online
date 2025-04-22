using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Person_Oops
    {
        static void Main(string[] args)

        {
             
            Student  student1 = new Student("Alice", 17);
            Teacher teacher1 = new Teacher("Mr. Smith", 40);

            student1.ShowDetails();
            student1.GetRole();

            Console.WriteLine();

            teacher1.ShowDetails();
            teacher1.GetRole();

            Console.ReadLine();
        }
    }
}
