using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificElements
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Employee() { }
        public Employee(int id, string name, int date)
        {
            Id = id;
            Name = name;
            Year = date;
        }
    }
}
