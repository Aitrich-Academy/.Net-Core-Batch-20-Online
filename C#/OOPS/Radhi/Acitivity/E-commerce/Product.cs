using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    public abstract class Product
    {
        public string Name;
        public double BasePrice;
        public abstract void GetProductDetails();
        public abstract double CalculateDiscount();
        public void Showprice()
        {
            Console.WriteLine($"Name:{Name} \n Base price:{BasePrice}\n ");
        }

    }
}
