using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_oops
{
    abstract class Banking
    {
        protected decimal balance;
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public void CheckBalance()
        {
            Console.WriteLine("Current Balance is :" + balance);

        }
        


    }
}
