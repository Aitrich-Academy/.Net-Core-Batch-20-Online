using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management
{
    internal class Product
    {
        public int ProductId;
        public string Name;
        public double Price;

        public Product(int productId, string name, double price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public void ShowProduct()
        {
            Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: ${Price}");
        }
    }
}
