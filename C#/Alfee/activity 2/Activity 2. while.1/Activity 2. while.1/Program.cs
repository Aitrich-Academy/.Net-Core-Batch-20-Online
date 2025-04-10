internal class Program
{
    private static void Main(string[] args)
    {
        double balance = 1000.0; // Initial account balance
        double withdrawalAmount;

        while (balance > 0)
        {
            Console.WriteLine("\nYour current balance is $" + balance + ".");
            Console.Write("Enter amount to withdraw (or 0 to exit): ");

            if (!double.TryParse(Console.ReadLine(), out withdrawalAmount))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Exit if user enters 0
            if (withdrawalAmount == 0)
            {
                Console.WriteLine("Thank you for using the ATM.");
                break;
            }

            // Validate withdrawal amount
            if (withdrawalAmount > 0 && withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;
                Console.WriteLine("Withdrawal successful. Remaining balance: $" + balance);
            }
            else if (withdrawalAmount > balance)
            {
                Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
            }
        }
    }
}