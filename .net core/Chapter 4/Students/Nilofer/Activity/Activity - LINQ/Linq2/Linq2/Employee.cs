using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    internal class Employee
    {
        public string Name;
        public int YearOfJoining;

        public Employee() { }

        public Employee(string name, int yearOfJoining)
        {
            Name = name;
            YearOfJoining = yearOfJoining;
        }
    }
}
