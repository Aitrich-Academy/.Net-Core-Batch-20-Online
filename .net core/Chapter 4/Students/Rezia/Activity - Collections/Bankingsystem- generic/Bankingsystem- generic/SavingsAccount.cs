using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankingsystem__generic.Exceptions;

namespace Bankingsystem__generic
{
    internal class SavingsAccount : BankAccount
    {
        public decimal interestRate;
        private int intialbalance = 1000;

        public SavingsAccount() : base("", "", 0) { }
        public SavingsAccount(string accountNumber, string accountholderName, decimal balance, decimal interestRate) : base(accountNumber, accountholderName, balance)
        {
            this.interestRate = interestRate;
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Dposit amount should be greater than zero");
            }
            Balance += amount;
            Console.WriteLine($"Amount Rs{amount} deposited Successfully, New Balance is Rs{Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException("Amount should be positive number");
            }
            if (Balance - amount < intialbalance)
            {
                throw new InsufficientBalanceException($"Insufficient Amount,Maintain initial balance Rs{intialbalance}");
            }
            Balance -= amount;
            Console.WriteLine($"Amount Rs{amount} Withdraw Successful, Balance is {Balance}");
        }
    }
}

