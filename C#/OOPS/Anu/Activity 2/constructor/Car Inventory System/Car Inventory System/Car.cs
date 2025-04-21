using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Inventory_System
{
    internal class Car
    {
        
        public string Brand;
        public string Model;
        public int Year;
        
        public Car()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Year = 0;
        }

         
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        
        public void DisplayCar()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }
}
