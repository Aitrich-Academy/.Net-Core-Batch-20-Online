using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Item

    {
        public string Name;
        private decimal price;
        public int quantity;

        public decimal Price
        {
            get { return price; }
           
            
        }

        public Item() { }

        public Item(string name, decimal price, int quantity)
        {
            Name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
