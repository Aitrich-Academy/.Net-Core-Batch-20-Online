using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount acc1 = new BankAccount(1001, "Alice Smith", 500.00m);
            BankAccount acc2 = new BankAccount(1002, "Bob Johnson", 1000.00m);

            Console.WriteLine("Initial Account Details:");
            acc1.DisplayAccount();
            acc2.DisplayAccount();

            acc1.Deposit(150.00m);
            acc2.Deposit(300.00m);

            Console.WriteLine("..............................");

            Console.WriteLine("Updated Account Details:");
            acc1.DisplayAccount();
            acc2.DisplayAccount();

            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
