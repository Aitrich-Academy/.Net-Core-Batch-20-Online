using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem__generic
{
    internal abstract class BankAccount
    {
        private string accountNumber;
        private string accountholderName;
        private decimal balance;

        public BankAccount(string accountNumber, string accountholderName, decimal balance)
        {
            Accountnumber = accountNumber;
            Accountholdername = accountholderName;
            Balance = balance;
        }

        public string Accountnumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string Accountholdername
        {
            get { return accountholderName; }
            set { accountholderName = value; }
        }
        public decimal Balance

        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public void Displaydetails()
        {
            Console.WriteLine($"Account Number : {Accountnumber}, Account Holder Name : {Accountholdername} , Balance : Rs{Balance} ");
        }
    }

}

