using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Current : Bank
    {
        public decimal rate_of_interst = 1.5M;
        public decimal OD = 5000;
        public Current() { }
        public Current(int accountNo, string holdername, decimal balance, decimal interst) : base(accountNo, holdername, balance, interst)
        {

        }
        public override void Deposit(decimal Amount)
        {
            decimal bal = Balance;
            Console.WriteLine("Previous balance is : {0}", bal);
            bal += Amount * (rate_of_interst / 100);
            Console.WriteLine("Your current balance is : {0}", bal);
            Console.WriteLine("You are succesfully deposited the amount......");
        }

        public override void Withdraw(decimal Amount)
        {
           
        }
    }
}
