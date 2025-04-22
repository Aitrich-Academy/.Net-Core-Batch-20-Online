using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_oops
{
    internal class Cars
    {
        public string Brand;
        public string Model;
        public int Year;

        public Cars()
        {
            Brand = "unknown";
            Model = "unknown";
            Year = 0;
        }

        public Cars(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void DisplayCars()
        {
            Console.WriteLine($"Brand:" + Brand);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Year:" + Year);
            Console.WriteLine();
        }
    }
}
