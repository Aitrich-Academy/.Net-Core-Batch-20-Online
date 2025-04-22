using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_oops
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
            Console.WriteLine("ID:" + ProductId);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine();
        }

    }
}
