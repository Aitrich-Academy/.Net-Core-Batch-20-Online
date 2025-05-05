using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public abstract class BankAccount
    {
        private int accountNumber;
        private string accountHolderName;
        private decimal balance;

        public int AccountNumber
        {
            get 
            { 
                return accountNumber; 
            }
            set
            { 
                accountNumber = value; 
            }
        }

        public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance; 
            }
            set
            { 
                balance = value;
            }
        }

        public BankAccount() { }

        public BankAccount(int accountNumber, string accountHolderName, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public void DisplayAccounts()
        {
            Console.WriteLine("Account No :{0} ",accountNumber);
            Console.WriteLine("Account Holder Name : {0}",accountHolderName);
            Console.WriteLine("Balance : {0}",Balance);
            Console.WriteLine("\n");
        }


    }
}
