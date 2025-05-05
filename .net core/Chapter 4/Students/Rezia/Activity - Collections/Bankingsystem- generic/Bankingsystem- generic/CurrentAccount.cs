using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankingsystem__generic.Exceptions;

namespace Bankingsystem__generic
{
    internal class CurrentAccount : BankAccount
    {
        public decimal overDraftlimit;

        public CurrentAccount() : base("", "", 0) { }
        public CurrentAccount(string accountNumber, string accountholderName, decimal balance, decimal overDraftlimit) : base(accountNumber, accountholderName, balance)
        {
            this.overDraftlimit = overDraftlimit;
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Amount should be positive");
            }
            Balance += amount;
            Console.WriteLine($"Amount Rs{amount} deposited successfully New Balance is {Balance}");

        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Amount should be positive");
            }
            if (Balance - amount < overDraftlimit)
            {
                throw new InsufficientBalanceException($"Withdrawal failed, your current balance is Rs{Balance}, overdraft limit exceeded");
            }
            Balance -= amount;
            Console.WriteLine("Amount Withdraw Successfully");
        }
    }
}
