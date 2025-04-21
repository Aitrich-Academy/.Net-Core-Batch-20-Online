using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public decimal Balance;

        public BankAccount(int accountNumber, string holderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = initialBalance;
        }

        public void DisplayAccount()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: $" + Balance);
            Console.WriteLine();
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount} to Account {AccountNumber}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
    }


}
