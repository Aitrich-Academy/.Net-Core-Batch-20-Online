using Shoppingcartscenario;

public class program
{
    public static void Main(string[] args)
    {

        var cart=new Shoppingcart();
        cart.AddItem(new Item("soap",20,5));
        cart.AddItem(new Item("cartoy",100,8));
        
        bool pgram=false;
        while(!pgram) 
        {
        Console.WriteLine("\n*** Welcome to Shopping Cart *** \n");
        Console.WriteLine("1. Add Items");
        Console.WriteLine("2. Remove Items");
        Console.WriteLine("3. Display items"); 
        Console.WriteLine("4. apply Discount");
        Console.WriteLine("5. Total Price");
        Console.WriteLine("6. Exit");
        Console.WriteLine("Enter an option: ");
        string option=Console.ReadLine();

            switch (option)
            {
                case "1":
                    additem(cart);
                    break;

                case "2":
                    removeitem(cart);
                    break;

                case "3":
                    cart.displayitems();
                    break;

                case "4":
                    applydiscount(cart);
                    break;

                case "5":
                    cart.totalprice();
                    break;

                case "6":
                    Console.WriteLine("Exiting....");
                    pgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice!!");
                    break;

            }
        }
    }


    private static void additem(Shoppingcart cart)
    {
        try
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            cart.AddItem(new Item(name, price, quantity));
            Console.WriteLine("Item added successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    private static void removeitem(Shoppingcart cart)
    {
        try
        {
            Console.Write("Enter item name to remove: ");
            string name = Console.ReadLine();
            cart.RemoveItem(name);
            Console.WriteLine("Item removed successfully!");
        }
        catch (NotfoundExeception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    private static void applydiscount(Shoppingcart cart)
    {
        Console.Write("Enter discount percentage: ");
        decimal percentage = decimal.Parse(Console.ReadLine());
        if (percentage != 0)
        {
            cart.applydiscount(percentage);

        }
        else
        {
            Console.WriteLine("Invalid discount percentage.");
        }
    }





    //public static void displayitem()
    //{
    //    if (count == 0)
    //    {
    //        Console.WriteLine("No items added");
    //        return;
    //    }
    //    else
    //    {
    //        for(int i=0; i < count; i++)
    //        {
    //            Console.WriteLine($"Item {i + 1}");
    //            items[i].display();
    //        }
    //    }
    //}

    //public static void Totalprice()
    //{

    //    foreach (Item item in items)
    //    {
    //        total += item.price * item.quantity;

    //    }
    //    Console.WriteLine($"Total price on the cart  is :{total}");
    //}




}
