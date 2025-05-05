using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeGroupBy
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        
        public int Salary { get; set; }

        public Employee() { }   

        public Employee(string name, string department, int salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}
