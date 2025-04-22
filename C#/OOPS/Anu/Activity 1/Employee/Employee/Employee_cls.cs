using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee_cls
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee_cls(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: $" + Salary);
        }
    }
}
