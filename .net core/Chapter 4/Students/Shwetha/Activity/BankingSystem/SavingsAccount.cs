using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class SavingsAccount : BankAccount
    {
        private decimal interest;
        private double amt;
        public double Amt {  get; set; }
        public decimal InterestRate {  get; set; }

        public SavingsAccount() { }
        public SavingsAccount(int aNo, string aHolderName, decimal bal ,decimal interestRate) : base(aNo,aHolderName,bal)
        {
            InterestRate = interestRate;
        }

        public override void Deposit(decimal amount)
        {
           
            Balance = amount + Balance;
            Console.WriteLine("Your savings account balance  :{0}", Balance);
            Regex Amountpattern =new Regex( @"^\d{1,12}(\.\d{1,2})?$");
            string check;
            try
            {
                string amt = Convert.ToString(amount);
               
                    Console.WriteLine("Enter the interest rate for savings account");
                    interest = Convert.ToDecimal(Console.ReadLine());
                
                    if (!Amountpattern.IsMatch(amt))
                    {

                        throw new InvalidAmountException();
                    }
                    else
                    {
                      
                        decimal result = (interest/100) * Balance;
                        Console.WriteLine("Total Amount is  : {0}", result);
                    }
                   
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
                string withdraw_amt = Convert.ToString(amount);
                Balance = Balance - amount;
                Console.WriteLine("Balance now is  : {0}", Balance);

                    if(Amountpattern.IsMatch(withdraw_amt))
                    {
                        if(Balance > 1000)
                        {
                            Console.WriteLine("You can withdraw the amount :{0}",withdraw_amt);
                        }
                        else
                        {
                            throw new InsufficientBalanceException();
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
