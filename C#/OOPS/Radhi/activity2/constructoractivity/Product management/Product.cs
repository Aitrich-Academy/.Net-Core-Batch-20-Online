using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_management
{
    internal class Product
    {
        public int ProductId;
        public string Name;
        public int Price;

       public Product (int productid, string name, int price)
        {
            ProductId = productid;
            Name = name;
            Price = price;
        }
        public void ShowProduct()
        {
            Console.WriteLine($"ProductId:{ProductId} \n Name:{Name} \n Price:{Price}");
        }

    }
}
