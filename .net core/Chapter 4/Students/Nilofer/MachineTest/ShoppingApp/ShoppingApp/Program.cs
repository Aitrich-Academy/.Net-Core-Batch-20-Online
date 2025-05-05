using ShoppingApp;
internal class Program
{
    private static void Main(string[] args)
    {
        ItemManager itemmanager = new ItemManager();
        string choice = "";

        try
        {
            while (choice != "5")
            {

                Console.WriteLine("Choose an option : ");
                Console.WriteLine("1 - Add item to the Cart");
                Console.WriteLine("2 - Remove item ");
                Console.WriteLine("3 - Display items in the cart with total price");
                Console.WriteLine("4 - Apply Discount");
                Console.WriteLine("5 - Exit");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        itemmanager.Additem();
                        break;
                    case "2":
                        itemmanager.Removeitem();
                        break;
                    case "3":
                        itemmanager.Displayitems();
                        break;
                    case "4":
                        itemmanager.ApplyDiscount();
                        break;
                    case "5":
                        Console.WriteLine("Exiting......");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }

        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}