using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankingSystem
{
    public class CurrentAccount : BankAccount
    {
        private decimal overdraft;
        private decimal interest;
        public decimal InterestRate { get; set; }
       
        public decimal OverDraft { get; set; }

        public CurrentAccount() { }
        public CurrentAccount(int aNo, string aHolderName, decimal bal, decimal overDraft ,decimal interest) : base(aNo, aHolderName, bal)
        {
            OverDraft = overDraft;
            InterestRate = interest;
        }

        public override void Deposit(decimal amount)
        {
            Regex Amountpattern = new Regex(@"^\d{1,12}(\.\d{1,2})?$");
            try
            {
                string amt = Convert.ToString(amount);
                //while (true)
                //{
                    if (Amountpattern.IsMatch(amt))
                    {
                        Console.WriteLine("Enter the interest rate for current account");
                        interest = Convert.ToDecimal(Console.ReadLine());
                        decimal result = interest * amount;
                        Console.WriteLine("Total Amount is  : {0}", result);
                    }
                    throw new InvalidAmountException();
                //}
            }
          catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public override void Withdraw(decimal amount)
        {
            Regex Amountpattern = new Regex(@"^\d{1,12}(\.\d{1,2})?$");
            try
            {
                string od_amt = Convert.ToString(amount);
                if(!Amountpattern.IsMatch(od_amt))
                {
                    throw new InvalidAmountException();
                }
                else
                {
                    if(overdraft >= 50000)
                    {
                        Console.WriteLine("You cannot withdraw the amount");
                    }
                    else
                    {
                        Console.WriteLine("Congrats.. you can have the money... {0}", od_amt);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
