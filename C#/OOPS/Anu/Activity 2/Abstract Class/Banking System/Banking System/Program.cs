using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Savings Account Operations ===");
            BankAccount savings = new SavingsAccount();
            savings.Deposit(1500);
            savings.Withdraw(1200);
            savings.Withdraw(900);
            savings.CheckBalance();

            Console.WriteLine("\n=== Current Account Operations ===");
            BankAccount current = new CurrentAccount();
            current.Deposit(500);
            current.Withdraw(800);
            current.Withdraw(300);
            current.CheckBalance();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
