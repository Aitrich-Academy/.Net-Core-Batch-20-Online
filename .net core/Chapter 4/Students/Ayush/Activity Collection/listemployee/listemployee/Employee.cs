using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listemployee
{
    public class Employee
    {
        public string id;
        public string name;
        public int age;
        public string department;

        public Employee() { }

        public Employee(string id, string name, int age, string department)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.department = department;
        }

        public void display()
        {
            Console.WriteLine("------Details------");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age :{age}");
            Console.WriteLine($"Department: {department}\n");
        }

        public void filterdpt()
        {
            Console.WriteLine("\n---FilterDetails---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Department: {department}");
        }
    }
}
