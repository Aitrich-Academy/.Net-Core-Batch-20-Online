using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public int Age;
        public string Department;

        public Employee() { }

        public Employee (int id, string name, int age, string department)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
        }

       

    }
}
