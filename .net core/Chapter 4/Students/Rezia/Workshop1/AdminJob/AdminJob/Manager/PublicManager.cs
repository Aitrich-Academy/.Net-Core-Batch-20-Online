using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminJob.Interface;
using AdminJob.Models;
using AdminJob.Repository;
using AdminJob.Enums;
using System.Text.RegularExpressions;
using AdminJob.Exceptions;

namespace AdminJob.Manager
{
    internal class PublicManager : IMenu
    {
        UserRepository userRepository = new UserRepository();
        User loggedUser = new User();
        bool isLoggedIn = false;
        IMenu menu;

        public void DisplayMenu()
        {
            showUserMenu();
        } 
        public void showUserMenu()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {

                Console.WriteLine("Choose an option");
                Console.WriteLine();
                Console.WriteLine("1. Login Admin");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        LoginAdmin();
                        if (isLoggedIn)
                            menu.DisplayMenu();
                        break;
                    case "2":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
        void LoginAdmin()
        {
            try
            {
                string email = GetEmail();
                Console.WriteLine("Enter enter your password");
                string password = Console.ReadLine();

                loggedUser =  userRepository.login(email, password);
                if (loggedUser != null)
                {
                    Console.WriteLine("Login Successfull");
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++");
                    isLoggedIn = true;
                    Console.WriteLine($"Welcome +++++++++++++ {loggedUser.FirstName} {loggedUser.LastName}+++++++++++++");
                    Console.WriteLine();
                    if (loggedUser.Role == Roles.Admin)
                    {
                      menu = new AdminManager(loggedUser);
                    }
                }
                else
                {
                    Console.WriteLine("Login failed , Please try again");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private string GetEmail()
        {
            try
            {
                Console.WriteLine("Enter your Email ID");
                string email = Console.ReadLine();

                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");
                if (!regex.IsMatch(email))
                
                    throw new InvalidFormatExceptions("The email format is not correct : " + email);
                    return email;
                
            }
            catch (InvalidFormatExceptions ex)
            {
                Console.WriteLine(ex.Message +"\n");
                Console.WriteLine("Try Again....");
                return GetEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \n");
                return GetEmail();
            }
        }
        private long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Enter your Phone Number");
               long phone = Convert.ToInt32(Console.ReadLine());
                return phone;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GetPhoneNumber();
            }
        }
    }
}

