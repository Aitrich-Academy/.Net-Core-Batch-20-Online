using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        string response="";

        do
        {
            int choice, quantityChoice, toppingChoice, totalPrice = 0, basePrice = 0;
            string menu = "";
            string[] quantities = { "300ml", "600ml", "900ml" };
            int[] quantityPrices = { 100, 200, 400 };

            Console.WriteLine("**** Coffee Menu **** \n1. Latte - $20 \n2. Americano - $30 \n3. Cappuccino - $60");
            Console.WriteLine("Enter your choice (1-3):");

            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    menu = "Latte";
                    basePrice = 20;
                    break;
                case 2:
                    menu = "Americano";
                    basePrice = 30;
                    break;
                case 3:
                    menu = "Cappuccino";
                    basePrice = 60;
                    break;
            }

            Console.WriteLine("Select your quantity: \n1. 300ml - $100 \n2. 600ml - $200 \n3. 900ml - $400");

            if (!int.TryParse(Console.ReadLine(), out quantityChoice) || quantityChoice < 1 || quantityChoice > 3)
            {
                Console.WriteLine("Invalid quantity. Please enter a number between 1 and 3.");
                continue;
            }

            totalPrice = basePrice + quantityPrices[quantityChoice - 1];

            Console.WriteLine($"Total Bill: \nMenu: {menu} - ${basePrice} \nQuantity: {quantities[quantityChoice - 1]} \nTotal: ${totalPrice}");

            Console.WriteLine("Would you like to add toppings? \n1. Milk - $20 \n2. Whipped Cream - $10 \n3. Sugar - $25 \n4. No Topping");

            if (!int.TryParse(Console.ReadLine(), out toppingChoice) || toppingChoice < 1 || toppingChoice > 4)
            {
                Console.WriteLine("Invalid choice. No toppings added.");
            }
            else
            {
                switch (toppingChoice)
                {
                    case 1:
                        totalPrice += 20;
                        Console.WriteLine("Topping: Milk");
                        break;
                    case 2:
                        totalPrice += 10;
                        Console.WriteLine("Topping: Whipped Cream");
                        break;
                    case 3:
                        totalPrice += 25;
                        Console.WriteLine("Topping: Sugar");
                        break;
                }
            }

            Console.WriteLine($"Final Total Bill: ${totalPrice}");

            Console.WriteLine("Do you want to order another coffee? (yes/no)");
             response = Console.ReadLine().ToLower();
            

        } while (response=="yes");

        Console.WriteLine("Thank you for your order!");
    }
}
