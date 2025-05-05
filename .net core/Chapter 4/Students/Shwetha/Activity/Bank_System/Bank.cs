using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public abstract class Bank
    {
        private int accountNo;
        private string holdername;
        private decimal balance;
        private decimal interst;
        public int minBalance = 1000;

        public int AccountNo { get; set; }
        public decimal Interest {  get; set; }
        public string HolderName { get; set; }
        public decimal Balance 
        {
            get { return balance; }
           
            set
            {
                if(minBalance <0 && balance == 0)
                {
                    Console.WriteLine("Can not Accept this");
                }
                else if(balance < 1000)
                {
                    Console.WriteLine("Amount is below 1000..... Minimum balance should be 1000");
                }
                else
                {
                    Balance = value;
                }
            }
        }

        public Bank() { }
        public Bank(int accountNo, string holdername, decimal balance , decimal interst)
        {
            AccountNo = accountNo;
            Balance = balance;
            HolderName = holdername;
            Interest = interst;
        }

        public abstract void Deposit(decimal  balance);
        public abstract void Withdraw(decimal  balance);
    }
}
