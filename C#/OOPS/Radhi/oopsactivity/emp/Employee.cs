using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public int salary;


        public void display()
        {
            Console.WriteLine($"ID:{Id} \n Name:{Name}\nSalary:{salary}");
        }
    }
}
