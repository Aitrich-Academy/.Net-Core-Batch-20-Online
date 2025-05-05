using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>
            {
                new BankAccount { AccountNumber = "001", AccountHolderName = "Nasif", Balance = 500, AccountType = "Savings" },
                new BankAccount { AccountNumber = "002", AccountHolderName = "Ami", Balance = 1500, AccountType = "Current" },
                new BankAccount { AccountNumber = "003", AccountHolderName = "Fiya", Balance = 900, AccountType = "Savings" },
                new BankAccount { AccountNumber = "004", AccountHolderName = "kunju", Balance = 2500, AccountType = "Current" },
                new BankAccount { AccountNumber = "005", AccountHolderName = "anu", Balance = 300, AccountType = "Savings" }
            };

            // 1. Find accounts with balance < 1000
            var lowBalanceAccounts = accounts.Where(a => a.Balance < 1000);
            Console.WriteLine("Accounts with balance less than 1000:");
            foreach (var acc in lowBalanceAccounts)
            {
                Console.WriteLine($"{acc.AccountHolderName} - {acc.AccountNumber} - Balance: {acc.Balance}");
            }

            // 2. Account with highest balance
            var highestBalanceAccount = accounts.OrderByDescending(a => a.Balance).FirstOrDefault();
            Console.WriteLine("\nAccount with the highest balance:");
            Console.WriteLine($"{highestBalanceAccount.AccountHolderName} - {highestBalanceAccount.AccountNumber} - Balance: {highestBalanceAccount.Balance}");

            // 3. Total bank balance
            var totalBalance = accounts.Sum(a => a.Balance);
            Console.WriteLine($"\nTotal Bank Balance: {totalBalance}");

            Console.ReadLine();
        }
    }
}
    

