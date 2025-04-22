using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class SavingsAccount:BankAccount
    {
        private const decimal overdraftLimit = -500;

        public override void deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"[Current] Deposited {amount}");
        }

        public override void withdraw(decimal amount)
        {
            if (balance - amount < overdraftLimit)
            {
                Console.WriteLine($"[Current] Overdraft limit exceeded. Cannot withdraw {amount}");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"[Current] Withdrawn {amount:C}");
            }
        }
    }
}
