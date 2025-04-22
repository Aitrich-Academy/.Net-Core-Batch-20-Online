using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_oops
{
    internal class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public void Displayinfo()
        {
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
