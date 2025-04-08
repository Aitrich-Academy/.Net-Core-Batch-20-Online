internal class Program
{
    private static void Main(string[] args)
    {
        decimal balance = 1000; // Initial account balance

        while (balance > 0)
        {
            Console.WriteLine($"Your current balance is ${balance}.");
            Console.Write("Enter amount to withdraw (or 0 to exit): ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount) || withdrawalAmount < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive numeric amount.");
                continue;
            }

            if (withdrawalAmount == 0)
            {
                Console.WriteLine("Thank you for using the ATM.");
                break;
            }

            if (withdrawalAmount > balance)
            {
                Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
            }
            else
            {
                balance -= withdrawalAmount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: ${balance}");
            }
        }

        Console.WriteLine("Your balance is 0. No further withdrawals possible.");
    }
}