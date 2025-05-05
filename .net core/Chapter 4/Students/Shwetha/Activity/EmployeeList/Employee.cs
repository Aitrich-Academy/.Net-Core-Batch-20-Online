using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Departments {  get; set; }
        public int Salary { get; set; }
        public Employee() { }
        public Employee(string name, string departments, int salary)
        {
            Name = name;
            Departments = departments;
            Salary = salary;
        }
    }
}
