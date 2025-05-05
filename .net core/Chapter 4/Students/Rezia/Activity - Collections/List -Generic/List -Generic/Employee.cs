using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List__Generic
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department {  get; set; }

        public Employee() { }

        public Employee(int id, string name, int age, string department)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;

        }
        public override string ToString()
        {
            return $" ID : {Id}, Name : {Name}, Age : {Age}, Department : {Department}";
        }
    }
}
