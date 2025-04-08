internal class Program
{
    private static void Main(string[] args)
    {
        double totalBill = 0;
        char continueOrder;

        do
        {
            Console.WriteLine("\nCoffee Menu:");
            Console.WriteLine("1. Espresso - $50");
            Console.WriteLine("2. Cappuccino - $70");
            Console.WriteLine("3. Latte - $80");
            Console.Write("Choose your coffee (1-3): ");

            int choice;
            double coffeePrice = 0;

            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please select a valid coffee.");
                continue;
            }

            switch (choice)
            {
                case 1: coffeePrice = 50; break;
                case 2: coffeePrice = 70; break;
                case 3: coffeePrice = 80; break;
            }

            Console.Write("Enter quantity: ");
            int quantity;
            if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a positive number.");
                continue;
            }

            double orderCost = coffeePrice * quantity;

            Console.WriteLine("Would you like to add toppings?");
            Console.WriteLine("1. Milk ($20)\n2. Sugar ($10)\n3. Whipped Cream ($25)\n4. No toppings");
            Console.Write("Choose a topping (1-4): ");

            int toppingChoice;
            if (int.TryParse(Console.ReadLine(), out toppingChoice))
            {
                switch (toppingChoice)
                {
                    case 1: orderCost += 20; break;
                    case 2: orderCost += 10; break;
                    case 3: orderCost += 25; break;
                    case 4: break;
                    default: Console.WriteLine("Invalid topping choice, no topping added."); break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, no topping added.");
            }

            totalBill += orderCost;
            Console.WriteLine("Current total: $" + totalBill);

            Console.Write("Would you like to order another coffee? (Y/N): ");
            continueOrder = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (char.ToUpper(continueOrder) == 'Y');

        Console.WriteLine("\nYour total bill is: $" + totalBill);
        Console.WriteLine("Thank you for your order! Have a great day!");
    }
}