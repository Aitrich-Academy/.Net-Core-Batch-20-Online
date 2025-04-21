using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    public class Cloth:Product
    {
        public string Size;
        public string Material;

        public Cloth(string name, double basePrice, string size, string material)
        {
            Name = name;
            BasePrice = basePrice;
            Size = size;
            Material = material;
        }

        public override void GetProductDetails()
        {
            Console.WriteLine($"Clothing Product: {Name}, Size: {Size}, Material: {Material}");
        }

        public override double CalculateDiscount()
        {
            double discount = BasePrice * 0.20;
            Console.WriteLine($"Discount on {Name}: ${discount}");
            return discount;
        }
    }
}
