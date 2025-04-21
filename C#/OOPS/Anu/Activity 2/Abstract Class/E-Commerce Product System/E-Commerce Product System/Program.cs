using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Product_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics lap = new Electronics(100000,"Apple-Air" ,"Apple");
            lap.ShowPrice();
            lap.GetProductDetails();
            lap.CalculateDiscount();

            Console.WriteLine("...............................");

            Clothing cloth = new Clothing(1000);
            cloth.ShowPrice();
            cloth.GetProductDetails();
            cloth.CalculateDiscount();

        }
    }
}
