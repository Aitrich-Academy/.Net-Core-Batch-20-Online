using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CompanyMember.Enums;
using CompanyMember.Exceptions;
using CompanyMember.Interfaces;
using CompanyMember.Models;
using CompanyMember.Repository;

namespace CompanyMember.Manager
{
    internal class ProviderManager : IMenu
    {
        IMenu menu;
        public User loggedUser = new User();
        bool isLoggedin = false;

        UserRepository userRepository= new UserRepository();
        public ProviderManager() { }

        public void DisplayMenu()
        {
            showUserMenu();
        }

        public void showUserMenu()
        {
            bool exitProgram = false;


            while (!exitProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegisterProvider();
                        break;
                    case "2":
                        LoginJobProvider();

                        if (isLoggedin)
                        {
                            menu.DisplayMenu();
                        }
                        break;
                    case "3":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
        public void RegisterProvider()
        {
            try
            {
                User newJobprovider = new User();

                Console.WriteLine("Please enter your first name:");
                newJobprovider.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter your last name:");
                newJobprovider.LastName = Console.ReadLine();

                newJobprovider.Email = GetEmail();

                Console.WriteLine("Please enter a password:");
                newJobprovider.Password = Console.ReadLine();
                
                bool isRegistered = userRepository.register(newJobprovider);

               
                if (isRegistered)
                {
                    Console.WriteLine("Registration successful! You can now log in.");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n"); }
        }

        public string GetEmail()
        {
            try
            {
                string pattern = "^\\S+@\\S+\\.\\S+$";
                Console.WriteLine("Enter your Email Address : ");
                string email = Console.ReadLine();
                if (Regex.IsMatch(email, pattern))
                {
                    return email;
                }
                throw new InvalidFormatException("Invalid email ," + email);
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again....");
                return GetEmail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
                Console.WriteLine("try again...");
                return GetEmail();

            }


        }

        public void LoginJobProvider()
        {
            try
            {
                string email = GetEmail();
                Console.WriteLine("Please Enter your Password : ");
                string password = Console.ReadLine();

                loggedUser = userRepository.Login(email, password);
                if (loggedUser != null)
                {
                    Console.WriteLine("Login successful!");
                    isLoggedin = true;
                    Console.WriteLine("Welcome " + loggedUser.FirstName);
                    if (loggedUser.Role == Roles.Jobprovider)
                    {
                        menu = new JobManager(loggedUser);
                    }
                }
                else
                {
                    Console.WriteLine("Login failed. Please try again.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

            }

        }
    

