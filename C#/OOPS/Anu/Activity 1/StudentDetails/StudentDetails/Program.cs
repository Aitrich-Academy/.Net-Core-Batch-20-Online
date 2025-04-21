using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();

             
            student1.Name = "Alice";
            student1.Age = 20;
            student1.Grade = "A";

             
            student1.DisplayDetails();

            Student student2 = new Student();


            student2.Name = "Anood";
            student2.Age = 25;
            student2.Grade = "B";


            student2.DisplayDetails();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
