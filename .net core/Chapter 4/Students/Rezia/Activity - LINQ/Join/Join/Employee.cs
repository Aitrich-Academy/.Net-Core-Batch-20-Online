using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Employee
    {
     
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee() { }

        public Employee(int  eid, string name, int age) 
        {
        EmployeeId = eid;
            Name = name;
            Age = age;
        }
    }
}
