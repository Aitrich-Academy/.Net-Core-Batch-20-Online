using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_oops
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public void Displaydetails()
        {
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: $" + Salary);
        }

    }
}
