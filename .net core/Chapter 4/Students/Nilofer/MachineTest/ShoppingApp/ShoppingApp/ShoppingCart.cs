using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class ShoppingCart
    {
        public static List<Item> items = new List<Item>();

        public void Additem(Item item)
        {
            items.Add(item);
        }

        public void Removeitem(Item item)
        {
           items.Remove(item);
         
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Item item in items)
            {
                total = total + (item.Price)*(item.quantity);
            }
            return total;
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public void ApplyDiscount(decimal discount)
        {
            decimal totalPrice = CalculateTotal();

            decimal discountAmount = (discount/100)*totalPrice;

            decimal PriceAfterDiscount = totalPrice - discountAmount;

            Console.WriteLine($"Total price after Discount = {PriceAfterDiscount}");
        }


    }
}
