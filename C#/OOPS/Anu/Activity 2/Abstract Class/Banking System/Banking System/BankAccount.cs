using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{

    abstract class BankAccount
    {
        protected decimal balance;
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {balance:C}");
        }

    }

    class SavingsAccount : BankAccount
    {
        private const decimal WithdrawalLimit = 1000m;

        public override void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"[Savings] Deposited: {amount:C}");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > WithdrawalLimit)
            {
                Console.WriteLine("[Savings] Withdrawal denied: exceeds limit.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("[Savings] Withdrawal denied: insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"[Savings] Withdrawn: {amount:C}");
            }
        }
    }

    class CurrentAccount : BankAccount
    {
        private const decimal OverdraftLimit = -500m;

        public override void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"[Current] Deposited: {amount:C}");
        }

        public override void Withdraw(decimal amount)
        {
            if (balance - amount < OverdraftLimit)
            {
                Console.WriteLine("[Current] Withdrawal denied: exceeds overdraft limit.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"[Current] Withdrawn: {amount:C}");
            }
        }

    }
}
