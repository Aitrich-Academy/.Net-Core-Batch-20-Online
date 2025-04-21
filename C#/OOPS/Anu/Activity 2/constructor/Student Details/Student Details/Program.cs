 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Alice", 101, "A");
            Student student2 = new Student("Bob", 102, "B+");

             
            student1.DisplayDetails();
            student2.DisplayDetails();

             
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
