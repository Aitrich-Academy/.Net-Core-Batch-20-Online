using System;
using System.Collections.Generic;
namespace Bank_System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Bank> list = new List<Bank>();
            Savings save_obj = new Savings();
            Current current_obj = new Current();
            string option, choice;
            do
            {
                try
                {
                    Console.WriteLine("Welcome to ABC Bank");
                    Console.WriteLine("::::::::::::::::::::::::::");
                    Console.WriteLine("1. Add Account");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Display");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("............................");
                    Console.WriteLine("Enter your choice here :");
                    option = Console.ReadLine();
                    switch(option)
                    {
                        case "1":
                            {
                                Account_Add();
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("A. Savings Account");
                                Console.WriteLine("B. Current Account");
                                Console.WriteLine("...........................");
                                Console.WriteLine("Choose the account Type");
                                option = Console.ReadLine();
                                if(option == "A" || option == "a")
                                {
                                    Console.WriteLine("Account number ..");
                                    int Acc_no = Convert.ToInt32(Console.ReadLine());
                                    foreach(var i in list)
                                    {
                                        if(Acc_no == i.AccountNo)
                                        {
                                            Console.WriteLine("Deposit Amount.");
                                            decimal amt = Convert.ToDecimal(Console.ReadLine());
                                            save_obj.Deposit(amt);
                                        }
                                        else
                                        {
                                            Console.WriteLine("That Account desnot exixt");
                                        }
                                    }
                                }
                                else if(option == "B" || option == "b")
                                {
                                    Console.WriteLine("Account number ..");
                                    int Acc_no = Convert.ToInt32(Console.ReadLine());
                                    foreach (var i in list)
                                    {
                                        if (Acc_no == i.AccountNo)
                                        {
                                            Console.WriteLine("Deposit Amount.");
                                            decimal amt = Convert.ToDecimal(Console.ReadLine());
                                            current_obj.Deposit(amt);
                                        }
                                        else
                                        {
                                            Console.WriteLine("That Account desnot exixt");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("That option desnot exixt");
                                }
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("A. Savings Account");
                                Console.WriteLine("B. Current Account");
                                Console.WriteLine("...........................");
                                Console.WriteLine("Choose the account Type");
                                option = Console.ReadLine();
                                if(option == "B" || option == "b")
                                {
                                    Console.WriteLine("Account number ..");
                                    int Acc_no = Convert.ToInt32(Console.ReadLine());
                                    foreach (var k in list)
                                    {
                                        if(Acc_no == k.AccountNo)
                                        {
                                            Console.WriteLine("Deposit Amount.");
                                            decimal amt = Convert.ToDecimal(Console.ReadLine());
                                            current_obj.Withdraw(amt);
                                        }
                                        else
                                        {
                                            Console.WriteLine("That Account desnot exixt");
                                        }
                                    }
                                }
                                else if(option == "A" || option == "a")
                                {
                                    Console.WriteLine("Account number ..");
                                    int Acc_no = Convert.ToInt32(Console.ReadLine());
                                    foreach (var j in list)
                                    {
                                        if (Acc_no == j.AccountNo)
                                        {
                                            Console.WriteLine("Deposit Amount.");
                                            decimal amt = Convert.ToDecimal(Console.ReadLine());
                                            save_obj.Withdraw(amt);
                                        }
                                        else
                                        {
                                            Console.WriteLine("That Account desnot exixt");
                                        }
                                    }

                                }
                                break;
                            }
                        case "4":
                            {
                                Show_Account();
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Exiting...................");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("That option desnot exixt");
                                break;
                            }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Do you wish to continue......(y/n)....?");
                choice = Console.ReadLine();
            }
            while (choice !="n" || choice != "N");

            void Account_Add()
            {
                try
                {
                    Console.WriteLine("A. Savings Account");
                    Console.WriteLine("B. Current Account");
                    Console.WriteLine("...........................");
                    Console.WriteLine("Choose the account Type");
                    option = Console.ReadLine();
                    if (option == "A" || option == "a")
                    {
                        Savings save = new Savings();
                        Console.WriteLine("Enter your Account nummber");
                        save.AccountNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your Account holder name");
                        save.HolderName = Console.ReadLine();
                        Console.WriteLine("Enter your Account Balance");
                        save.Balance = Convert.ToDecimal(Console.ReadLine());
                        // decimal total = save.Balance * save.rate_of_interst;
                        list.Add(save);
                    }
                    else if (option == "B" || option == "b")
                    {
                        Current current = new Current();
                        Console.WriteLine("Enter your Account nummber");
                        current.AccountNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your Account holder name");
                        current.HolderName = Console.ReadLine();
                        Console.WriteLine("Enter your Account Balance");
                        current.Balance = Convert.ToDecimal(Console.ReadLine());
                        // decimal total = save.Balance * save.rate_of_interst;
                        list.Add(current);
                    }
                    else
                    {
                        Console.WriteLine("That option desnot exixt");
                    }
                }
               catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            void Show_Account()
            {
                Console.WriteLine("The account details displaying here.......");
                foreach (var item in list)
                {
                    Console.WriteLine(item.AccountNo);
                    Console.WriteLine(item.HolderName);
                    Console.WriteLine(item.Balance);
                    Console.WriteLine("................................");
                }
            }
        }
    }
}
