using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank;

public class CurrentAccount: BankAccount
{
    private const decimal withdrawalLimit = 1000;

    public override void deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"[Savings] Deposited {amount}");
    }

    public override void withdraw(decimal amount)
    {
        if (amount > withdrawalLimit)
        {
            Console.WriteLine($"[Savings] Withdrawal limit exceeded. Max allowed: {withdrawalLimit}");
        }
        else if (amount > balance)
        {
            Console.WriteLine($"[Savings] Insufficient balance.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"[Savings] Withdrawn {amount}");
        }
    }

}
