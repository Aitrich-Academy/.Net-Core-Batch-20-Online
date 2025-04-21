using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    public class Electronic:Product
    {
        public string Brand;
       

        public Electronic(string name, double basePrice, string brand)
        {
            Name = name;
            BasePrice = basePrice;
            Brand = brand;
            
        }
        public override void GetProductDetails()
        {
            Console.WriteLine($"Electronics Product: {Name}, Brand: {Brand}");
        }
        public override double CalculateDiscount()
        {
            double discount = BasePrice * 0.20; // 20% discount
            Console.WriteLine($"Discount on {Name}: ${discount}");
            return discount;
        }
    }
}
