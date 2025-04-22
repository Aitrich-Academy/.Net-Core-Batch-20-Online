using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class Car
    {
        public string Model;
        public int Year;

        public void display()
        {
            Console.WriteLine($"Model:{Model} \n Year:{Year}");

        }

    }
}
