using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Savings : Bank
    {
        public decimal rate_of_interst = 4.5M;
        public Savings() { }
        public Savings(int accountNo, string holdername, decimal balance, decimal interst) : base (accountNo,holdername,balance,interst)
        {

        }
        public override void Deposit(decimal Amount)
        {
            decimal bal = Balance;
            Console.WriteLine("Previous balance is : {0}", bal);
            bal += Amount * (rate_of_interst/100);  
            Console.WriteLine("Your current balance is : {0}" ,bal);
            Console.WriteLine("You are succesfully deposited the amount......");
        }

        public override void Withdraw(decimal Amount)
        {
            decimal avil_bal = Balance;
            Console.WriteLine("Avilable balnce is : {0}" , avil_bal);
            if (avil_bal > Amount)
            {
                avil_bal -= Amount;
                if (avil_bal < 1000)
                {
                    Console.WriteLine(" Can not withdarw the amount ... minimum balance should be 1000");
                }
                else
                {
                    Console.WriteLine("Your balance is now : {0}", avil_bal);
                }
            }
            else if (Amount <= 0)
            {
                Console.WriteLine("Invalid amount figure");
            }
            else
            {
                Console.WriteLine("Amount granted : {0}" ,Amount);
                Console.WriteLine("Available balance is  : {0}", avil_bal);
            
            }
        }
    }
}
