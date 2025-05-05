using BankingSystemwithList.Exceptions;
using BankingSystemwithList;

internal class Program
{
   
    
    public static List <BankAccount> accounts = new List <BankAccount>();
    private static void Main(string[] args)
    {
        int accountNumber;
        BankAccount account;
        decimal amount;
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("-----Choose an option-------");
            Console.WriteLine("1 - Create a new Account ");
            Console.WriteLine("2 - Deposit an amount");
            Console.WriteLine("3 - Withdraw an amount");
            Console.WriteLine("4 - Exit Application");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateAccount();
                    break;

                case "2":

                    while (true)
                    {
                        try
                        {

                            Console.WriteLine("Enter Account Number :");
                            accountNumber = Convert.ToInt32(Console.ReadLine());
                            account = FindAccount(accountNumber);



                            if (account == null)
                            {
                                throw new AccountNotFoundException("Account not found..Reenter account Number");
                            }
                            Console.WriteLine("Enter Amount to Deposit");
                            amount = Convert.ToDecimal(Console.ReadLine());
                            account.Deposit(amount);
                            break;
                        }

                        catch (AccountNotFoundException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    break;




                case "3":

                    while (true)
                    {
                        try
                        {

                            Console.WriteLine("Enter Account Number :");
                            accountNumber = Convert.ToInt32(Console.ReadLine());
                            account = FindAccount(accountNumber);
                            if (account == null)
                            {
                                throw new AccountNotFoundException("Account not found.. ");

                            }

                            Console.WriteLine("Enter Amount to Withdraw");
                            amount = Convert.ToDecimal(Console.ReadLine());
                            account.Withdraw(amount);

                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter numeric values only.");
                        }

                        catch (AccountNotFoundException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"An unexpected error occurred: {e.Message}");
                        }
                    }
                    break;



                case "4":

                    Console.WriteLine("Exiting .......");
                    break;

                default:
                    Console.WriteLine("Invalid inpt");
                    break;


            }
        }
    }

    public static BankAccount FindAccount(int accountNumber)
    {


        for (int i = 0; i < accounts.Count; i++)
        {
            if (accounts[i].AccountNumber == accountNumber)
            {
                return accounts[i];
            }
            
        }


        return null;
    }





    public static void CreateAccount()
    {
        Console.WriteLine("Choose Account type : ");
        Console.WriteLine("1 - Saving Account");
        Console.WriteLine("2 - Current Account");

        string input = Console.ReadLine();

        Console.WriteLine("Enter Account Number : ");
        int accountNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Account Holder Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Initial Balance : ");
        decimal balance = Convert.ToDecimal(Console.ReadLine());

        if (input == "1")
        {
            Console.WriteLine("Enter Interest rate");
            decimal interestRate = Convert.ToDecimal(Console.ReadLine());

            SavingAccount savingaccount = new SavingAccount(accountNo, name, balance, interestRate);

            accounts.Add(savingaccount);
    

            Console.WriteLine("Account added successfully");
            foreach (BankAccount bankaccount in accounts)
            {
                if (bankaccount != null)
                {
                    bankaccount.DisplayAccounts();
                }
            }

        }
        else if (input == "2")
        {
            Console.WriteLine("Enter Over draft limit : ");
            decimal overDraftLimit = Convert.ToDecimal(Console.ReadLine());

            CurrentAccount currentaccount = new CurrentAccount(accountNo, name, balance, overDraftLimit);
            accounts.Add(currentaccount);

            
            Console.WriteLine("Account added successfully");
            foreach (BankAccount bankaccount in accounts)
            {
                if (bankaccount != null)
                {
                    bankaccount.DisplayAccounts();
                }
            }

        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}