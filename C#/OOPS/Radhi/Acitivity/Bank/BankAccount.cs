using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank;

public abstract class BankAccount
{
    protected decimal balance;
    public abstract void  deposit(decimal amount);
    public abstract void withdraw(decimal amount);
    public void CheckBalance()
    {

        Console.WriteLine($"current Balance{balance}");

    }
    
}
