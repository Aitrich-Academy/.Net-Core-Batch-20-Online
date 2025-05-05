using System.Threading.Tasks.Dataflow;
using System.Transactions;
using Bankingsystem;

public class Program 
{
    public static Bankaccount[] accounts = new Bankaccount[100];
    public static int count = 0;
    public static void Main(string[] args)
    {
        bool pgrm = false;


        while (!pgrm)
        {
            Console.WriteLine("\n-----Welcome to Bank System-------");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter an choice: ");
            string choice = Console.ReadLine();
        

            switch (choice)
            {
                case "1":
                     Createaccount();
                    break;


                case "2":
                    Deposit();
                    break;

                case "3":
                    withdraw();
                    break;

                case "4":
                    display();
                    break;

                case "5":
                    Console.WriteLine("Exiting");
                    return;

                default:
                    Console.WriteLine("Invalid option!!!");
                    break;
            }
        }
    }

  public static void Createaccount()
    {
        Console.WriteLine("\n1.Saving Account");
        Console.WriteLine("2. CurrentAccount");
        Console.WriteLine("Enter an option: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            try
            {
                Console.WriteLine("Enter account number: ");
                string accountnumber = Console.ReadLine();
                Console.WriteLine("Enter Account name: ");
                string holder = Console.ReadLine();
                Console.WriteLine("Enter balance: ");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                if (balance < 0)
                {
                    throw new Exception("balance must be positive!!");
                }
                Console.WriteLine("Enter intrest rate: ");
                decimal intrest = Convert.ToDecimal(Console.ReadLine());

                accounts[count] = new SavingsAccount(accountnumber, holder, balance, intrest);
                count++;
                Console.WriteLine("Account created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        else if (option == "2")
        {
            try
            {
                Console.WriteLine("Enter account number: ");
                string accountnumber = Console.ReadLine();
                Console.WriteLine("Enter Account name: ");
                string holder = Console.ReadLine();
                Console.WriteLine("Enter balance: ");
                decimal balance = Convert.ToDecimal(Console.ReadLine());
                if (balance < 0)
                {
                    throw new Exception("balance must be positive!!");
                }
                Console.WriteLine("Enter overdraft :");
                decimal overdraft = Convert.ToDecimal(Console.ReadLine());
                accounts[count] = new CurrentAccount(accountnumber, holder, balance, overdraft);
                count++;
                Console.WriteLine("Account created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine("invalid choice!!!");
            return;
        }
    }


    public static void Deposit()
    {
        Console.WriteLine("Enter account number: ");
        string accountnumber= Console.ReadLine();
        bool found=false;

        for (int i = 0; i < count; i++)
        {
            if (accounts[i].Accountnumber == accountnumber)
            {
                found = true;
                try 
                { 
                Console.WriteLine("Enter deposit amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                accounts[i].deposit(amount);
                    Console.WriteLine("Deposited successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            }
        }
          if(!found)
        {
            Console.WriteLine("Account not found!!!");
            return;
        }

    }


    public static void withdraw()
    {
        Console.WriteLine("Enter account number: ");
        string accountnumber = Console.ReadLine();
        bool found=false;

        for (int i = 0; i < count; i++)
        {
            found=true;
            if (accounts[i].Accountnumber == accountnumber)
            {
                try
                {
                Console.WriteLine("Enter withdraw amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                
                 accounts[i].Withdraw(amount);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            }
            if (!found) 
            {
                Console.WriteLine("Account not found!!!");
                return;
            }
        }

    }

    public static void display()
    {
        if (count == 0)
        {
            Console.WriteLine("No accounts are created!!");
            return;
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nAccount {i + 1}");
                accounts[i].displaydetails();
            }
        }
    }
}
