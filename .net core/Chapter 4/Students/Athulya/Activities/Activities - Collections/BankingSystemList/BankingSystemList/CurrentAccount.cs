using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemList
{
    internal class CurrentAccount : BankAccount
    {
        public decimal OverDraftLimit;


        public CurrentAccount(int accountNumber, string accountHolderName, decimal balance, decimal overdraftLimit) : base(accountNumber, accountHolderName, balance)
        {
            OverDraftLimit = overdraftLimit;
        }

        public CurrentAccount() { }


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
                    if (amount > Balance || Balance - amount < OverDraftLimit)
                    {
                        throw new InsufficientBalanceException("Insufficient Balance");
                    }
                    Balance = Balance - amount;
                    Console.WriteLine("Withdrawal successfull. Available Balane is {0} ",Balance);
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
                    Console.WriteLine("Enter amount");
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

        public override void Deposit(decimal amount)
        {

            while (true)
            {

                try
                {
                    if (amount <= 0)
                    {
                        throw new InvalidAmountException();
                    }
                    Balance = Balance + amount;
                    Console.WriteLine("Amount Deposited successfully . Available Balance  = {0}",Balance);

                    break;

                }
                catch (InvalidAmountException e)
                {
                    Console.WriteLine("Invalid Amount. Enter a Valid Amount");
                    amount = Convert.ToDecimal(Console.ReadLine());

                }
            }

        }
    }
}


