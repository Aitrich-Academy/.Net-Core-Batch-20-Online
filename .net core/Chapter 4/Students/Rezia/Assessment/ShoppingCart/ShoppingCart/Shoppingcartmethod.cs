using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Shoppingcartmethod
    {
        List<Shoppingcartitem> items = new List<Shoppingcartitem>()
        {
            new Shoppingcartitem("LapTop-HP",45000,3),
            new Shoppingcartitem("Tablet-SamsungA9",75000,4),
            new Shoppingcartitem("Mobile-Applei20",90000,2),
            new Shoppingcartitem("Led TV- Sony",125000,1)

            };
        
        public void Additem(Shoppingcartitem item)
        {
            items.Add(item);
        }
        public void Removeitem(string item)
        {
            var itemname= items.FirstOrDefault(i => i.Itemname==item);
            if (itemname != null)
            {
                items.Remove(itemname);
            }
            else
            {
                throw new InvalidOperationException($"Item {itemname} is not found");
            }
        }
        public decimal Calculateitemprice()
        {
            return items.Sum(i => i.TotalPrice());

        }
        public decimal DiscountRate(decimal discountrate)
        {
            if (discountrate < 0 || discountrate > 20)
            {
                throw new ArgumentException("Discount should be positive number");
            }
            decimal totalitemprice = Calculateitemprice();
            decimal discountrateprice = totalitemprice * (discountrate / 100);
            decimal finalprice = totalitemprice -  discountrateprice;

            Console.WriteLine($"Discount Applied : {discountrate}");
            Console.WriteLine($"Final Price : {finalprice}");
            return finalprice;  

        }
        public void DisplayItem()
        {
            if (items.Any())
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"Item Name : {item.Itemname}, Item Price : {item.Price}, Item Quantity : {item.Quantity}");
                }
            }
            else
            {
                Console.WriteLine("Item cart is empty");
            }
        }
    }
}
   


