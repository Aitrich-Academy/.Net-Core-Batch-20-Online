using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_oops
{
    internal class Account
    {
        public int AccountNumber; 
        public string HolderName; 
        public double Balance; 

        public Account(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void DisplayAccount()
        {
            Console.WriteLine("Account:" + AccountNumber);
            Console.WriteLine("Holder Name:" + HolderName);
            Console.WriteLine("Balance:" + Balance);
            Console.WriteLine(); 
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"₹{amount} deposited. New Balance: ₹{Balance}");
        }
    }
}
