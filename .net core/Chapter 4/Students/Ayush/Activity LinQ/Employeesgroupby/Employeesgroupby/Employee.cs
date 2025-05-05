using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeesgroupby
{
    public class Employee
    {
        public string name;
        public string department;
        public int salary;

        public Employee() { }

        public Employee(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
    }
}
