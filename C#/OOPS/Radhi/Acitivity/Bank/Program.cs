using Bank;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount savings = new SavingsAccount();
        BankAccount current = new CurrentAccount();

        Console.WriteLine("=== Savings Account ===");
        savings.deposit(1500);
        savings.withdraw(1200); // Should be denied due to limit
        savings.withdraw(800);  // Allowed
        savings.CheckBalance();

        Console.WriteLine("\n=== Current Account ===");
        current.deposit(1000);
        current.withdraw(1400); // Allowed (overdraft)
        current.withdraw(200);  // Denied (exceeds overdraft)
        current.CheckBalance();
    }
}