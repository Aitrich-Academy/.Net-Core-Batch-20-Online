using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public abstract class BankAccount
    {
        private int accountNo;
        private string accountHolderName;
        private decimal balance;

        public int AccountNo {  get { return accountNo; } set { accountNo = value; } }
        public string AccountHolderName { get { return accountHolderName; } set { accountHolderName = value; } }
        public decimal Balance 
        {
            get { return balance; } 
            set 
            {
                if(balance < 0 || balance == 0 )
                {
                    balance = 0;
                    //Console.WriteLine(" this balance can not accaept ...\n ....Please enter the value again");
                }
              else if(balance <1000)
                {
                    balance = 0;
                    //Console.WriteLine("Minimum balance should be 1000/-");
                }
                else
                {
                    balance = value;
                }
              
            } 
        }

       public BankAccount() { }
        public BankAccount(int aNo, string aHolderName, decimal bal)
        {
            AccountNo = aNo;
            AccountHolderName = aHolderName;
            Balance = bal;
        }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

      
    }
}
