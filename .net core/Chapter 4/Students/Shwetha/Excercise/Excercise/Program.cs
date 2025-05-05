using System;
using Excercise.Interface;
using Excercise.Manager;
using Excercise.Model;
using Excercise.Repository;
namespace Excercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IUserInterface userInterface = new UserRepository() ;  
            string choice, option;
            do
            {
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Seeker Register");
                Console.WriteLine("3. Provider Register");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose your option........");
                option = Console.ReadLine();
                try
                {
                    switch (option)
                    {
                        case "1":
                            {
                                Login();
                                break;
                            }
                        case "2":
                            {
                                registerSeeker();
                                break;
                            }
                        case "3":
                            {
                                registerProvider();
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Exiting..... \n GoodBye.....!!!");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine("Do you wish to continue (y/n)...?");
                choice = Console.ReadLine();
            } while (choice == "Y" || choice == "y");
            void registerSeeker()
            {
               User registerUser = new User();
               Console.WriteLine("Welcome to Jobportal System");
               Console.WriteLine("::::::::::::::::::::::::::::::::::::::");
               Console.WriteLine("Enter your name :");
               registerUser.Name = Console.ReadLine();
               Console.WriteLine("Enter your Email :");
               registerUser.Email = Console.ReadLine();
               Console.WriteLine("Enter your Password :");
               registerUser.Password = Console.ReadLine();
                Console.WriteLine("Enter your Phone number :");
                registerUser.Phone =Convert.ToInt64(Console.ReadLine());
                //Console.WriteLine("Enter your Role :");
                registerUser.roles = Enums.Roles.JobSeeker;
                userInterface.registerSeeker(registerUser);          
            }
            void registerProvider()
            {
                User registerUser = new User();
                Console.WriteLine("Welcome to Jobportal System");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("Enter your name :");
                registerUser.Name = Console.ReadLine();
                Console.WriteLine("Enter your Email :");
                registerUser.Email = Console.ReadLine();
                Console.WriteLine("Enter your Password :");
                registerUser.Password = Console.ReadLine();
                Console.WriteLine("Enter your Phone number :");
                registerUser.Phone = Convert.ToInt64(Console.ReadLine());
                //Console.WriteLine("Enter your Role :");
                registerUser.roles = Enums.Roles.Jobprovider;
                userInterface.registerProvider(registerUser);
            }
            void Login()
            {
                try
                {
                Console.WriteLine("Enter your Email Id");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your Password");
                string password = Console.ReadLine();
                var loggedUser = userInterface.Login(email, password);
               
                    if (loggedUser !=null)
                    {
                        Console.WriteLine("Welcome {0}",loggedUser.Name);
                        Console.WriteLine("You succesfully logged in job portal system....");
                        if (loggedUser.roles == Enums.Roles.Jobprovider)
                        {
                            IMenu menu = new JobProviderManager();
                            menu.DisplayMenu();
                        }
                        else if (loggedUser.roles == Enums.Roles.JobSeeker)
                        {
                            IMenu menu = new JobSeekerManager();
                            menu.DisplayMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Role");
                        }
                    }
                    else
                    {
                        throw new CustomException();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            void providerList()
            {
                try
                {
                    string choice, option;
                    do
                    {
                        Console.WriteLine("Do you wish to continue...(y/n)");
                        choice = Console.ReadLine();
                    }while (choice != null);

                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
