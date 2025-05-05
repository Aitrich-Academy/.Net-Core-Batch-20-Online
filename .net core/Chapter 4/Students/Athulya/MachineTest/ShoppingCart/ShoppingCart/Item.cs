using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public  class Item
    {
        private string name { get; set; }
        private double price {  get; set; }
        private int quantity {  get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public Item(string name, double price, int quantity)
        {
           this. Name = name;
           this. Price = price;
           this. Quantity = quantity;
        }


    }
}
