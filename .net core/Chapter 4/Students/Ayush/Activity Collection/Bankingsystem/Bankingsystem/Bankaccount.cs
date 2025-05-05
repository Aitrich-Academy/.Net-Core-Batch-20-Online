using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem
{
    public abstract class Bankaccount
    {
        public string Accountnumber;
        public string Holdername;
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("balance cannot be negative");
                    value = 0;
                }
                else
                {
                    balance = value;
                }
            }
        }

        public Bankaccount(string accountnumber, string holdername, decimal balance)
        {
            this.Accountnumber = accountnumber;
            this.Holdername = holdername;
            this.Balance = balance;
        }




        public abstract void deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public void displaydetails()
        {
            Console.WriteLine("---Details---");
            Console.WriteLine($"AccountNumber : {Accountnumber}");
            Console.WriteLine($"Holder Name : {Holdername}");
            Console.WriteLine($"Balance : {Balance}");

        }
    }
}
