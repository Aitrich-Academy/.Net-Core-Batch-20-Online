using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Interface;

namespace Finance.Model
{
    public class AccountManager
    {
        public void CreateSavingsAccount()
        {
            Console.WriteLine("_________Savings Acoount_______");
            Console.WriteLine("Enter Savings Account Holder Name");
            string holder=Console.ReadLine();


            Console.WriteLine("Enter savings Account Balance");
            double balance=Convert.ToDouble(Console.ReadLine());

            SavingsAccount savings=new SavingsAccount(holder, balance);
            savings.DisplayAccountInfo();

            double interst = savings.CalculateInterest();
            Console.WriteLine($"Intrest :{interst}");
            Console.WriteLine();

        }

public void CreateCurrentAccount()
        {
            Console.WriteLine("----Current Account------");
            Console.WriteLine("Enter current Account Holder Name");
            string holder=Console.ReadLine();
            Console.WriteLine("enter current Account Balance");
            double balance= Convert.ToDouble(Console.ReadLine());

            CurrentAccount current =new CurrentAccount(holder, balance);
            current.DisplayAccountInfo();

            current.ApplyMaintenanceFee();
            Console.WriteLine("After applying Maintenance fee:");
            current.DisplayAccountInfo();
            Console.WriteLine();

        }





    }
}
