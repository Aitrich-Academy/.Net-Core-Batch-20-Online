using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Exceptions;

namespace ShoppingCart
{
    public class ShoppingCart
    {

        List<Item> items = new List<Item>();

        public void AddItem()
        {
            try
            {
                Console.WriteLine("Enter the Name of the item ");
                
                string name = Console.ReadLine();

                double price = GetPrice();

                int quantity = GetQuantity();
                Item newItem = new Item(name, price, quantity);
                items.Add(newItem);
                Console.WriteLine("Item Added ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }



        public void DisplayItems()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine(" Item Name  \t  Price  \t Quantity");
            Console.WriteLine("*******************************************");
            foreach (Item item in items)
            {
                Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Quantity);

            }
            Console.WriteLine("*******************************************");
            Console.WriteLine("\n");
        }

        public double GetPrice()
        {
            try
            {
                Console.WriteLine("Enter the price of the item : ");
                double price = Convert.ToDouble(Console.ReadLine());
                if (price<0)
                {
                    throw new PriceCannotNegativeException("Price cannot be null or negative");
                }
                return price;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetPrice();
            }


        }
        public int GetQuantity()
        {
            try
            {
                Console.WriteLine("Enter the quantity of the item : ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity == null)
                {
                    Console.WriteLine("Quantity cannot be null or negative");
                }
                return quantity;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetQuantity();
            }


        }
        public void RemoveItem()
        {
            try
            {
                Console.WriteLine("Enter item name to remove from the list : ");
                var remItem = Console.ReadLine();
                var rem = items.Find(e => e.Name == remItem);

                if (items.Contains(rem))
                {
                    items.Remove(rem);
                    Console.WriteLine("Item removed ");
                }
                else
                {
                    throw new ItemNotFoundException("Item not found");

                }
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
               

            }

        }

        public double CalculatePrice()
        {
            double Total = items.Sum(e => e.Price * e.Quantity);
            Console.WriteLine("Total price is : " + Total);
            return Total;
        }

        public void CalculateDiscount()
        {
            double TPrice = CalculatePrice();
            double discountPrice = TPrice * 0.05;
            try
            {
                double actualPrice = TPrice - discountPrice;
                if (actualPrice > 0)
                {
                    Console.WriteLine("Discounted Price is :" + actualPrice);
                }
                else
                {
                    throw new PriceCannotNegativeException(" price cannot be negative");
                }
            }
            catch (PriceCannotNegativeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n");
                CalculateDiscount();
            }
        }
    }
}
   







