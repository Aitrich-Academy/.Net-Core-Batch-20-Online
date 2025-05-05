using System;
namespace BankingSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BankAccount[] account = new BankAccount[100];
            SavingsAccount savings = new SavingsAccount();
            CurrentAccount current = new CurrentAccount();
           
            int count = 0;
            string acc_type , acc_Name;
            int acc_No;
            decimal i_Rate;
            decimal od;
            string choice, option;
            try
            {
                do
                {
                    Console.WriteLine("Welcome XYZ Banking System");
                    Console.WriteLine("...........................");
                    Console.WriteLine("1. Open an Account (Savings or Current)");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Display ");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Select one option from the above");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            {
                                Add();
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Enter the Account type(savings / current )");
                                string type = Console.ReadLine();
                                Console.WriteLine("Enter the account number");
                                int ac_no = Convert.ToInt32(Console.ReadLine());
                               foreach(var obj in account)
                                {
                                    obj.AccountNo = ac_no;
                                    if (type == "savings" || type == "Savings")
                                    {
                                        Console.WriteLine("Enter the Amount");
                                        string amot = Console.ReadLine();
                                        decimal dec_amt = decimal.Parse(amot);
                                        savings.Deposit(dec_amt);

                                    }
                                    else if (type == "Current" || type == "current")
                                    {
                                        Console.WriteLine("Enter the amount");
                                        string amot = Console.ReadLine();
                                        decimal dec_amt = decimal.Parse(amot);
                                        current.Deposit(dec_amt);
                                    }
                                    else
                                    {
                                        throw new TypeException();
                                    }
                                }
                              

                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Choose 0 for withdraw & 1 for Overdraft");
                                int ch = Convert.ToInt32(Console.ReadLine());
                                if (ch == 1)
                                {
                                    Console.WriteLine("Enter the amount ");
                                    decimal od_amount = Convert.ToDecimal(Console.ReadLine());
                                    current.Withdraw(od_amount);

                                }
                                else
                                {
                                    Console.WriteLine("Enter the amount ");
                                    decimal wit_amount = Convert.ToDecimal(Console.ReadLine());
                                    current.Withdraw(wit_amount);
                                }
                                break;
                            }
                        case "4":
                            {
                                Display();
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Leaving......... please wait...");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice");
                                break;
                            }
                    }
                    Console.WriteLine("Do you wish to continue the system : {y / n} ?");
                    choice = Console.ReadLine();

                } while (choice == "y" || choice == "Y");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          

            void Add()
            {
               

                try
                {
                    Console.WriteLine("How many Accounts you need to open");
                    count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count;)
                    {
                        Console.WriteLine("Account Type (Savings or Current)");
                        acc_type = Console.ReadLine();
                        Console.WriteLine("Enter Account No");
                        acc_No = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Accont holder's name");
                        acc_Name = Console.ReadLine();
                        Console.WriteLine("Balance");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());

                        if (acc_type == "Savings" || acc_type == "savings")
                        {
                            Console.WriteLine("Interest rate");
                            i_Rate = Convert.ToDecimal(Console.ReadLine());
                            SavingsAccount save = new SavingsAccount(acc_No, acc_Name, balance, i_Rate);
                            account[i] = save;
                            Console.WriteLine("Savings Account added succesfully");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Interest rate");
                            i_Rate = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Enter OD Amount");
                            od = Convert.ToDecimal(Console.ReadLine());
                            CurrentAccount current = new CurrentAccount(acc_No, acc_Name, balance, i_Rate, od);
                            account[i] = current;
                            Console.WriteLine("Current Account added succesfully");
                            i++;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            }
             void Display()
            {
               
                if (account != null)
                {
                    Console.WriteLine("Stored Accounts are :");
                    foreach (var item in account)
                    {
                        if (item != null)
                        {
                            Console.WriteLine("Account no : {0}", item.AccountNo);
                            Console.WriteLine("Name of the account holder :{0}", item.AccountHolderName);
                            Console.WriteLine("Balance : {0}" ,item.Balance); ;
                            Console.WriteLine("*********************************");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nothing to display.......\n Add Accounts...");
                }
            }
        }

        }
    }

