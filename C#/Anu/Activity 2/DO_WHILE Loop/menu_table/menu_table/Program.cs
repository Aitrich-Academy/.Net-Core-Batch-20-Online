internal class Program
{
    private static void Main(string[] args)
    {
        double totalBill = 0;

        do
        {
            Console.WriteLine("\nWelcome to the Coffee Shop!");
            Console.WriteLine("1. Espresso - 100");
            Console.WriteLine("2. Cappuccino - 150");
            Console.WriteLine("3. Latte - 130");
            Console.WriteLine("4. Exit");
            Console.Write("Select a coffee option (1-4): ");
            int coffeeChoice = Convert.ToInt32(Console.ReadLine());

            if (coffeeChoice == 4)
                break;

            double coffeePrice = 0;
            switch (coffeeChoice)
            {
                case 1:
                    coffeePrice = 100;
                    break;
                case 2:
                    coffeePrice = 150;
                    break;
                case 3:
                    coffeePrice = 130;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    continue;
            }

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            double subTotal = coffeePrice * quantity;

            Console.WriteLine("\nWould you like to add toppings?");
            Console.WriteLine("1. Milk (20)");
            Console.WriteLine("2. Sugar (10)");
            Console.WriteLine("3. Whipped Cream (25)");
            Console.WriteLine("4. No toppings");
            Console.Write("Select a topping option (1-4): ");
            int toppingChoice = Convert.ToInt32(Console.ReadLine());

            double toppingPrice = 0;
            switch (toppingChoice)
            {
                case 1:
                    toppingPrice = 20;
                    break;
                case 2:
                    toppingPrice = 10;
                    break;
                case 3:
                    toppingPrice = 25;
                    break;
                case 4:
                    toppingPrice = 0;
                    break;
                default:
                    Console.WriteLine("Invalid topping choice. No topping added.");
                    toppingPrice = 0;
                    break;
            }

            double orderTotal = subTotal + (toppingPrice * quantity);
            totalBill += orderTotal;

            Console.WriteLine($"Subtotal for this order: {orderTotal}.");
            
            string response = Console.ReadLine().Trim().ToLower();
            bool continueOrdering = response == "yes";

            if (!continueOrdering)
                break;

        } while (true);
        //while (response == "yes");
        Console.WriteLine($"\nYour total bill is: {totalBill}");
        Console.WriteLine("Thank you for visiting our Coffee Shop!");
    }
}
