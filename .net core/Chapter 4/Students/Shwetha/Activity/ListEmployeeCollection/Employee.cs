using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEmployeeCollection
{
    internal class Employee
    {
        public Employee() { }
        private int id;
        private string name;
        private int age;
        private string department;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, int age, string department)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
        
        }
      
    }
}
