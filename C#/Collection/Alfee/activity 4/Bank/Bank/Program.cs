using System;
using System.Collections.Generic;
using System.Linq;

class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public decimal Balance { get; set; }
    public string AccountType { get; set; }

    public BankAccount(string accountNumber, string accountHolderName, decimal balance, string accountType)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = balance;
        AccountType = accountType;
    }
}

class Program
{
    static void Main()
    {
        // List of bank accounts
        List<BankAccount> accounts = new List<BankAccount>
        {
            new BankAccount("101", "Alice", 500.00m, "Savings"),
            new BankAccount("102", "Bob", 1500.00m, "Checking"),
            new BankAccount("103", "Charlie", 200.00m, "Savings"),
            new BankAccount("104", "David", 3000.00m, "Checking"),
            new BankAccount("105", "Eve", 800.00m, "Savings")
        };

        // 1. Find accounts with Balance < 1000
        var lowBalanceAccounts = from account in accounts
                                 where account.Balance < 1000
                                 select account;

        Console.WriteLine("Accounts with Balance < 1000:");
        foreach (var account in lowBalanceAccounts)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Holder: {account.AccountHolderName}, Balance: {account.Balance:C}");
        }

        // 2. Find the account with the highest balance
        var highestBalanceAccount = accounts.OrderByDescending(a => a.Balance).FirstOrDefault();

        if (highestBalanceAccount != null)
        {
            Console.WriteLine($"\nAccount with Highest Balance: ");
            Console.WriteLine($"Account Number: {highestBalanceAccount.AccountNumber}, Holder: {highestBalanceAccount.AccountHolderName}, Balance: {highestBalanceAccount.Balance:C}");
        }

        // 3. Calculate the total bank balance
        decimal totalBankBalance = accounts.Sum(a => a.Balance);

        Console.WriteLine($"\nTotal Bank Balance: {totalBankBalance:C}");
    }
}