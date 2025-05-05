using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystemwithList.Exceptions;

namespace BankingSystemwithList
{
    internal class SavingAccount:BankAccount
    {
        public decimal interestRate;

        public SavingAccount(int accountNumber, string accountHolderName, decimal balance, decimal interestrate) : base(accountNumber, accountHolderName, balance)
        {
            interestRate = interestrate;
        }

        public SavingAccount() { }

        public override void Deposit(decimal amount)
        {
            while (true)
            {
                try
                {
                    if (amount <= 0)
                    {
                        throw new InvalidAmountException("Enter Valid amount");
                    }
                    Balance = Balance + amount;
                    Console.WriteLine($"Available Balance  = {Balance}");
                    break;
                }
                catch (InvalidAmountException e)
                {
                    Console.WriteLine(e.Message);
                    amount = Convert.ToDecimal(Console.ReadLine());
                }

            }
        }

        public override void Withdraw(decimal amount)
        {
            while (true)
            {
                try
                {
                    if (amount <= 0)
                    {
                        throw new InvalidAmountException("Enter a valid amount");
                    }
                    if (Balance - amount < 1000)
                    {
                        throw new InsufficientBalanceException("Insufficient balance. a minimum balance 1000 should be maintained");

                    }
                    Balance = Balance - amount;
                    Console.WriteLine($"Withdrawal successfull. Available Balane is {Balance}");
                    break;
                }
                catch (InvalidAmountException e)
                {
                    Console.WriteLine(e.Message);
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
                catch (InsufficientBalanceException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please enter valid amount to withdraw ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Enter amount");
                    amount = Convert.ToDecimal(Console.ReadLine());
                }
            }
        }
    }
}
