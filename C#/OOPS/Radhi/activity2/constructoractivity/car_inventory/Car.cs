using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_inventory
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public string Year;
         
        public Car()
        {
            Brand ="Toyota";
            Model = "Wangnor";
            Year = "2020";


        }
        public Car(string brand, string model,String year)
        {
            Brand = brand;
            Model = model;
            Year = year;

        }
        public void DisplayCar()
        {
            Console.WriteLine($"Brand:{Brand} \n Model:{Model} \n Year:{Year}");
        }



    }
}
