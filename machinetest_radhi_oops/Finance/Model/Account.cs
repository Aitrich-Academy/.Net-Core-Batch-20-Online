using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public abstract class Account
    {
        
        public string? AccountName { get; set; }
        public double Balance {  get; set; }

        public Account ( string accountName,double balance)
        {
           
            AccountName = accountName;
            Balance = balance;
        }
        
        public abstract void DisplayAccountInfo();
        

        
    }
}
