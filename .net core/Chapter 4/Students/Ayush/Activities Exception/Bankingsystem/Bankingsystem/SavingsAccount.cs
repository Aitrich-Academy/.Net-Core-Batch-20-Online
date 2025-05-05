using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem
{
    public class SavingsAccount : Bankaccount
    {
        public decimal Intrestrate;
        public  decimal minbalance = 1000;

       

        public SavingsAccount(string accountnumber,string Holdername,decimal balance,decimal intrestrate):
            base(accountnumber,Holdername,balance)
        {
            Intrestrate = intrestrate;
        }

       

        public override void deposit(decimal amount)
        {
            
            if (amount <= 0)
            {
                throw new Exception("Deposit amount must be greater than zero");
            }
                Balance =Balance+ amount;
            Console.WriteLine($"Deposited amount {amount} and Balance is {Balance}");
            
        }


        public override void Withdraw(decimal amount)
        {
            if (Balance < 1000)
            {
                throw new Exception("Balance cannot go under $1000");
                
                
            }
            if (amount <= 0)
            {
                throw new Exception("amount must be positive");
            }
            else if (Balance - amount < minbalance) 
            {
                throw new Exception("Insufficient balance!!!");

            }
            Balance = Balance-amount;
            Console.WriteLine($"withdrawed {amount} and the balance is {Balance}");
        }

    }
}
