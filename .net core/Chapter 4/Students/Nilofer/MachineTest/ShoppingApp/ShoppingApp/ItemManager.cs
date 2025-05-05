using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingApp.Exceptions;

namespace ShoppingApp
{
    internal class ItemManager

    {
        List<Item> products = new List<Item>()
        {
            new Item("Laptop",20000,0),
            new Item("Iphone",50000,0),
            new Item("Airpode",10000,0),
            new Item("Bluetooth",5000,0),
            new Item("Headphone",3000,0)
        };
        ShoppingCart cart = new ShoppingCart();
        public void Additem()
        {
            try
            {
                Console.WriteLine("{0,-15} {1,-15}", "Name", "Price");
                foreach(Item item1 in products)
                {
                    Console.WriteLine("{0,-15} {1,-15}",item1.Name,item1.Price);
                }
                Console.WriteLine();
                Console.WriteLine("Enter item Name : ");
                string name = Console.ReadLine().ToLower();
                Item product = FindProduct(name);
                
                if (product != null)
                {

                    Console.WriteLine("Enter Quantity : ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Item item = new Item(name, product.Price, quantity);
                    cart.Additem(item);
                }
                else
                {
                    throw new ItemnotFoundException("Item not Found");
                }
            }
            catch(ItemnotFoundException e)
            {
                Console.WriteLine(e.Message);

                Additem();

            }
           
        }

        public Item FindProduct(string name)
        {
            return products.FirstOrDefault(x => x.Name.ToLower() == name);
        }

        public void Removeitem()
        {
            try
            {
                Console.WriteLine("Enter item Name to remove : ");
                string name = Console.ReadLine().ToLower();
                Item item = Finditem(name);
                if (item != null)
                {
                    cart.Removeitem(item);
                    Console.WriteLine("Item Removed Successfully");
                }
                else
                {
                    throw new ItemnotFoundException("Item not Found");
                }
            }catch (ItemnotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Removeitem();
            }
        }
        public Item Finditem(string name)
        {
          return ShoppingCart.items.FirstOrDefault(x => x.Name.ToLower() == name);
        }

        public void Displayitems()
        {
            try
            {
                List<Item> items = cart.GetItems();

                foreach (Item item in items)
                {
                    Console.WriteLine($"Item Name : {item.Name}  Price : {item.Price}  Quantity : {item.quantity}");
                }
                Console.WriteLine();
                decimal total = cart.CalculateTotal();
                Console.WriteLine($"Total Price : {total}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ApplyDiscount()
        {
            Console.WriteLine("Enter Discount Percentage : ");
            decimal discount = Convert.ToDecimal(Console.ReadLine());
            cart.ApplyDiscount(discount);
        }


    }
}
