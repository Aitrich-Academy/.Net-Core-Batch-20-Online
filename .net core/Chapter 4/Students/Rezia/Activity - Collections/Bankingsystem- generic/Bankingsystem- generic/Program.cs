using Bankingsystem__generic.Exceptions;
using Bankingsystem__generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<BankAccount> users = new List<BankAccount>();
        int choice;

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create new User Account (Savings or Current)");
            Console.WriteLine("2. Deposit Amount");
            Console.WriteLine("3. Withdraw Amount");
            Console.WriteLine("4. Display Account Details");
            Console.WriteLine("5.Exit the application");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number");
                continue;
            }
            try
            {

                switch (choice)
                {
                    case 1:
                        NewAccount(users);
                        break;
                    case 2:
                        DepositAmount(users);
                        break;
                    case 3:
                        WithdrawAmount(users);
                        break;
                    case 4:
                        DisplayDetails(users);
                        break;
                    case 5:
                        Console.WriteLine("Exiting the Application.... goodbye");
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (choice != 5);
    }
    private static void NewAccount(List<BankAccount> users)
    {

        Console.WriteLine("\n Create new Account");
        Console.WriteLine("Enter Account Number");
        string acntnum = Console.ReadLine();

        Console.WriteLine("Enter Account Holder Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the initial balance");
        if (!decimal.TryParse(Console.ReadLine(), out decimal initialbalance) || initialbalance < 0)
        {
            throw new InvalidAmountException("Initial balance should be positive number");
        }

        Console.WriteLine("Enter Account type (Savings or Current) ");
        string accounttype = Console.ReadLine();

        if (accounttype.ToLower() == "savings")
        {
            Console.WriteLine("Enter the Interest Rate");
            if (!decimal.TryParse(Console.ReadLine(), out decimal rate) || rate < 0)
            {
                throw new InvalidAmountException("Rate should be positive number");
            }
            users.Add(new SavingsAccount { Accountnumber = acntnum, Accountholdername = name, Balance = initialbalance, interestRate = rate });
            Console.WriteLine("Savings account created successfully");
        }
        else if (accounttype.ToLower() == "current")
        {
            Console.WriteLine("Enter the over draft limit");

            if (!decimal.TryParse(Console.ReadLine(), out decimal overdraft) || overdraft < 0)
            {
                throw new InvalidAmountException("Limit should be positive number");
            }

            users.Add(new CurrentAccount { Accountnumber = acntnum, Accountholdername = name, Balance = initialbalance, overDraftlimit = overdraft });
            Console.WriteLine("Current account created successfully");
        }
        else
        {
            Console.WriteLine("Invalid Account Type");
            return;
        }
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
    public static void DepositAmount(List<BankAccount> users)
    {
        Console.WriteLine("Enter the account number to deposit into");
        string depositaccntno = Console.ReadLine();
        var account = FindAcntbynum(depositaccntno, users);

        if (account != null)
        {
            Console.WriteLine("Enter the amount to be deposited");
            decimal depamount = decimal.Parse(Console.ReadLine());

            try
            {
                account.Deposit(depamount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Account not found");
        }

    }
    public static void WithdrawAmount(List<BankAccount> users)
    {
        Console.WriteLine("Enter the account number to withdraw into");
        string withdrawaccountno = Console.ReadLine();
        var account = FindAcntbynum(withdrawaccountno, users);

        if (account != null)
        {

            Console.WriteLine("Enter the amount to withdrwa Rs");
            decimal withdrawamount = decimal.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(withdrawamount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Account not found");
        }

    }
    public static BankAccount FindAcntbynum(string accountnumber, List<BankAccount> users)
    {
        foreach (var user in users)
        {
            if (user != null && user.Accountnumber == accountnumber)
            {
                return user;
            }
        }
        return null;
    }

    public static void DisplayDetails(List<BankAccount> users)
    {
        Console.WriteLine("Enter the account number to display");
        string acnunumtodisplay = Console.ReadLine();
        var acnttodisp = FindAcntbynum(acnunumtodisplay, users);

        if (acnttodisp != null)
        {
            acnttodisp.Displaydetails();
        }
        else
        {
            Console.WriteLine("Acount not found");
        }
    }
}