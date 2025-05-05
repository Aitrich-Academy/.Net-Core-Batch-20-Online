using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofEmployeeLINQ
{
    internal class Employee
    {
        public string name {  get; set; }
        public string department { get; set; }  
        public int salary { get; set; }
        public Employee() { }
        public Employee(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
                this.salary = salary;

        }
    }
}
