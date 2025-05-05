using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcartscenario
{
    public  class Shoppingcart
    {
        public List<Item> items=new List<Item>();
         
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void RemoveItem(string itemname)
        {
            var item = items.Find(e => e.Itemname == itemname);
            if (item == null)
                throw new NotfoundExeception($"Item '{itemname}' not found in the cart.");
            items.Remove(item);
        }


        public void displayitems()
        {
            if (items == null)
            {
                Console.WriteLine("no items found!!!");
                return;
            }
            Console.WriteLine("\n items in the cart are:");
            foreach (var item in items)
            {
                item.display();
            }
        }

        public int totalprice()
        {
            int total = 0;
            foreach (Item item in items)
            {
                total += item.price * item.quantity;

            }
            Console.WriteLine($"total is {total}");
            return total;
        }

        public void applydiscount(decimal percentage)
        {
            int total=totalprice();
            decimal discount=total *(percentage/100);
            decimal discounttotalprice = total - discount;
            Console.WriteLine($"Discount is {discounttotalprice}");
        }

    }
}
