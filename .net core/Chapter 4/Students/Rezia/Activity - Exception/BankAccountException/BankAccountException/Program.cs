using BankAccountException;

internal class Program
{
    private static BankAccount[] users = new BankAccount[10];
   private static int usercount = 0;
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the Banking System");

        while (true)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Create new User Account (Savings or Current)");
            Console.WriteLine("2. Deposit Amount");
            Console.WriteLine("3. Withdraw Amount");
            Console.WriteLine("4. Display Account Details");
            Console.WriteLine("5.Exit the application");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NewAccount();
                    break;
                case "2":
                    DepositAmount();
                    break;
                case "3":
                    WithdrawAmount();
                    break;
                case "4":
                    DisplayDetails();
                    break;
                case "5":
                    Console.WriteLine("Exiting the Application.... goodbye");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    private static void NewAccount()
    {
        if (usercount >= users.Length)
        {
            Console.WriteLine("Limit reached, Cannot create more account");
            return;
        }

        Console.WriteLine("\n Create new Account");
        Console.WriteLine("Enter Account Number");
        string acntnum = Console.ReadLine();

        Console.WriteLine("Enter Account Holder Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Account type (Savings or Current) ");
        string accounttype = Console.ReadLine();

        if (accounttype.ToLower() == "savings")
        {
            Console.WriteLine("Enter the Interest Rate");
            decimal rate = decimal.Parse(Console.ReadLine());

            SavingsAccount savings = new SavingsAccount
           
            {
                Accountnumber = acntnum,
                Accountholdername = name,
                Balance = 0,
                interestRate = rate
            };
            users[usercount] = savings;
            usercount++;
            Console.WriteLine("Savings account created successfully");
        }
        else if (accounttype.ToLower() == "current")
        {
            Console.WriteLine("Enter the over draft limit");
            decimal draft = decimal.Parse(Console.ReadLine());

            CurrentAccount current = new CurrentAccount
            {
                Accountnumber = acntnum,
                Accountholdername = name,
                overDraftlimit = draft
            };
            users[usercount] = current;
            usercount++;
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
    public static void DepositAmount()
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
        }else {
            Console.WriteLine("Account not found");
        }

    }
    public static void WithdrawAmount()
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
        } else
        {
            Console.WriteLine("Account not found");
            }
        
    }
    public static BankAccount FindAcntbynum(string accountnumber, BankAccount[] users)
    {
        foreach (var user in users) {
            if (user != null && user.Accountnumber == accountnumber)
            {
                return user;
            }
        }
            return null;
    }

    public static void DisplayDetails()
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



