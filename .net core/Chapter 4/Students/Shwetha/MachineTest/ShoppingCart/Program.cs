using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using ShoppingCart.Exceptions;
using ShoppingCart.Interface;
using ShoppingCart.Repository;
namespace ShoppingCart
{
    internal class Program
    {
        private static readonly Regex NamePattern = new Regex(@"^[a-zA-Z\s\-]+$");
        public static void Evaluate(string name)
        {
            if(!NamePattern.IsMatch(name))
            {
                throw new NameException();
            }
        }
        public static void EvaluateQuantity(double qty)
        {
            if (qty <= 0)
            {
                throw new InvalidQuantityException();
            }
        }
        public static void Main(string[] args)
        {
            List<Shopping_Cart> CartList = new List<Shopping_Cart>()
            {
                new Shopping_Cart(1,"Egg", 3.5 ),
                new Shopping_Cart(2,"Milk", 12.0 ),
                new Shopping_Cart(3,"Shampoo", 150.0 ),
                new Shopping_Cart(4,"Bread", 45.0 ),
                new Shopping_Cart(5,"MatchBox", 10.0),
                new Shopping_Cart(6,"Pen", 5.0),
                new Shopping_Cart(7,"Bag", 250.0 ),
                new Shopping_Cart(8,"Book", 70.0 )
            };

            IDiscountInterface discount = new DiscountRepository(CartList);
            string choice, option;
            try
            {
                do
                {
                    Console.WriteLine("Welcome to the shopping cart");
                    Console.WriteLine("::::::::::::::::::::::::::::::::::::::::");
                    Console.WriteLine("0. Show Items");
                    Console.WriteLine("1. Add items");
                    Console.WriteLine("2. Remove items");
                    Console.WriteLine("3. Discount and Total Price");
                    Console.WriteLine("Please give your choice.......");
                    option = Console.ReadLine();
                    switch(option)
                    {
                        case "0":
                            {
                                Console.WriteLine("Total Items in the Shop");
                                Console.WriteLine("************************************");
                                foreach (var item in CartList)
                                {
                                    Console.WriteLine("Id :{0} Name :{1} Price :{2}",item.Id,item.Name,item.Price);
                                }
                                break;
                            }
                        case "1":
                            {
                                try
                                {
                                    Console.WriteLine("Enter the Id");
                                    int product_Id = Convert.ToInt32(Console.ReadLine());

                                   
                                    var existingItem = discount.find(product_Id);

                                    if (existingItem != null)
                                    {
                                        Console.WriteLine($"Item '{existingItem.Name}' already exists in the cart.");
                                    }

                                    double product_Quantity;
                                    Shopping_Cart shopping_Cart = new Shopping_Cart();

                                    while (true)
                                    {
                                        Console.WriteLine("Enter the Quantity");
                                        product_Quantity = Convert.ToDouble(Console.ReadLine());
                                        EvaluateQuantity(product_Quantity);
                                        break;
                                    }

                                    shopping_Cart.Id = product_Id;
                                    shopping_Cart.Quantity = product_Quantity;

                                    discount.Add(shopping_Cart);

                                    Console.WriteLine("Item successfully added to the cart.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error: {ex.Message}");
                                }
                                break;
                            }
                        case "2":
                            {
                                try
                                {
                                    Console.WriteLine("Your Cart items......");
                                    Console.WriteLine("----------------------------------");
                                    discount.showCart();
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine();
                                    Console.WriteLine("Enter the Id  of the item");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    discount.RemoveItem(id);
                                    Console.WriteLine("Your Cart Items........");
                                    Console.WriteLine("----------------------------------");
                                    discount.showCart();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }

                                break;
                            }
                        case "3":
                            {
                                try
                                {
                                   
                                        Console.WriteLine("Enter the discount category (Golden - 10%, Silver - 5%, Platinum - 15%):");
                                        string discountCategory = Console.ReadLine();

                                        double disc_Percentage;

                                        switch (discountCategory)
                                        {
                                            case "golden":
                                            disc_Percentage = 10.0;
                                                break;
                                            case "silver":
                                            disc_Percentage = 5.0;
                                                break;
                                            case "platinum":
                                            disc_Percentage = 15.0;
                                                break;
                                            default:
                                                Console.WriteLine("Invalid discount category! Please choose Golden, Silver, or Platinum.");
                                                return;
                                        }

                                        
                                        double totalPrice = discount.Discount(disc_Percentage);
                                        Console.WriteLine("Final Price After Discount: {0}", totalPrice);
                                }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                            
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice..");
                                break;
                            }
                    }
                    Console.WriteLine("Do you wish to continue...(y/n)...?");
                    choice = Console.ReadLine();
                }
                while (choice == "Y" || choice == "y");
            }
         catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}