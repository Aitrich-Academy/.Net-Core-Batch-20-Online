using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class CurrentAccount:Account
    {
        const double monthly_fee = 10.00;
        public CurrentAccount(string accountName, double balance) : base(accountName, balance) { }
        public void ApplyMaintenanceFee()
        {
            Balance = Balance - monthly_fee;
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"____current Account___ \nHolder:{AccountName} \nBalance:{Balance}");

        }
    }
}
