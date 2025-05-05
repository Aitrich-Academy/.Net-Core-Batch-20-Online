using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem
{
    public class CurrentAccount : Bankaccount
    {
        public decimal overdraftlimit;

        public CurrentAccount(string Accountnumber,string Holdername,decimal balance,decimal overdraftlimit) : 
            base(Accountnumber,Holdername,balance)
        {
            overdraftlimit = overdraftlimit;
        }

        public override void deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Deposit amount must be positive!!!");
            }
            Balance =Balance+ amount;
            Console.WriteLine($"Deposited {amount} successfully , Balance: {Balance}");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("withdraw amount must be positive!!!");
            }
            else if (Balance - amount < overdraftlimit)
            {
                throw new Exception("Insufficient amount!!!");
            }
            Balance =Balance- amount;
            Console.WriteLine($"withdrew {amount} successfully, Balance: {Balance}");
        }

    }
}
