using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    public class Bank
    {
        public string AccountNumber;
        public string HolderName;
        public double Balance;

        public Bank(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }
      public  void DisplayAccount()
        {
            Console.WriteLine($"AccountNumber:{AccountNumber} \nHolderName:{HolderName} \nBalance:{Balance}");

        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited $" + amount + " to account " + AccountNumber);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
    }
}
