using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>()
            {
                new Product(1, "Laptop", 999.99),
                new Product(2, "Smartphone", 499.50),
                new Product(3, "Headphones", 89.99)
            };

            Console.WriteLine("Product List:");

            foreach (Product product in productList)
            {
                product.ShowProduct();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
