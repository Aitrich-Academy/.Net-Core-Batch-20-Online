using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Interface;

namespace Finance.Model
{
    public class SavingsAccount:Account,IIntrestCalculate
    {
        const double Intrestrate = 0.05;
        public SavingsAccount(string accountName, double balance):base(accountName,balance){ }
        public double CalculateInterest()
        {
            return Balance * Intrestrate;
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"___Savings Account____ \nAccount Holder:{AccountName} \nBalance:{Balance}");
        }
    }
}
