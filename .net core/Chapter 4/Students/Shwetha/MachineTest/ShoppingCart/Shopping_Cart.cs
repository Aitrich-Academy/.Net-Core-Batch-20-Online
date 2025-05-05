using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Shopping_Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public double Quantity { get; set; }

        public Shopping_Cart() { }
        public Shopping_Cart(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
            
        }
    }
}
