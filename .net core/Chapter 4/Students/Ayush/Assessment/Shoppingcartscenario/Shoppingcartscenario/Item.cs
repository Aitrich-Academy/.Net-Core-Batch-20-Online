using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcartscenario
{
    public class Item
    {
        private string itemname;

        public string Itemname
        {
            get { return itemname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    value = null;
                    Console.WriteLine("Item name cannot be empty!!!");

                }
                else
                {
                    itemname = value;
                }
            }
        }

        public int price;
        public int quantity;

        public Item() { }

        public Item(string Itemname, int price, int quantity)
        {
            this.Itemname = Itemname;
            this.price = price;
            this.quantity = quantity;
        }


        public void display()
        {
            Console.WriteLine($"Name: {itemname}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Price: {price}");
        }
    }
}
