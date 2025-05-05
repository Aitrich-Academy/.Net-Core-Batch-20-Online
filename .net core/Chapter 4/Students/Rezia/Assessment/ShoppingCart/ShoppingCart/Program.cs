using ShoppingCart;
internal class Program
{
    private static void Main(string[] args)
    {

        Shoppingcartmethod item = new Shoppingcartmethod();

        bool exitprogram = false;

        while (!exitprogram) {
            Console.WriteLine("********Welcome to Virtual Shopping Cart**********");

            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. List Items");
            Console.WriteLine("4. Apply Discount");
            Console.WriteLine("5. Calculte Total Price");
            Console.WriteLine("6. Exit");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Enter the item name :");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter the price of item : ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the quantity of item : ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        item.Additem(new Shoppingcartitem(name, price, quantity));
                        Console.WriteLine("-----Item Added Successfully---------");
                        break;

                    case "2":
                        Console.WriteLine("Enter the name of item to be remove");
                        string itemname = Console.ReadLine();

                        item.Removeitem(itemname);
                        Console.WriteLine("Item Removed Successfully");
                        break;

                    case "3":
                        Console.WriteLine("Display list of items");
                        item.DisplayItem();
                        break;

                    case "4":
                        Console.WriteLine("Discount Rate of item ");
                        decimal discountrate = decimal.Parse(Console.ReadLine());   
                        item.DiscountRate(discountrate);
                        break;

                    case "5":
                        Console.WriteLine("Total Price of items :");
                        item.Calculateitemprice();
                        break;

                    case "6":
                        exitprogram = true;
                        Console.WriteLine("Exiting the Application........ GoodBye..........");
                        return;

                    default:
                        Console.WriteLine("Invalid option, please try again ");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice, please enter correct option");
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}