using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee_cls emp1 = new Employee_cls(1, "Anood", 50000);
            emp1.DisplayDetails();


            Employee_cls emp2 = new Employee_cls(2, "Nasif", 10000);
            emp2.DisplayDetails();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
