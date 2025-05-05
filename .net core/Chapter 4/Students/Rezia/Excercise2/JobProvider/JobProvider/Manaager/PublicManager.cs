using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Interface;
using JobProvider.Repository;
using JobProvider.Models;
using JobProvider.Exceptions;
using System.Text.RegularExpressions;
using JobProvider.Enums;

namespace JobProvider.Manaager
{
    internal class PublicManager : IMenu
    {
        List<User> users = new List<User>();
        UserRepository userRepository = new UserRepository();

        public User loggedUser = new User();
        bool isLoggedIn = false;
        IMenu menu;

        public void DisplayMenu()
        {
            showmenuUser();
        }
        public void showmenuUser()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        LoginProvider();
                        break;
                    case "2":
                        RegisterProviderorSeeker();
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
        void LoginProvider()
        {
            try
            {
                string email = GetEmail();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                loggedUser = userRepository.Login(email, password);
                if (loggedUser != null)
                {
                    Console.WriteLine("++++++++++Login Successfully++++++++++++++");
                    isLoggedIn = true;
                    Console.WriteLine();
                    Console.WriteLine($"Welcome {loggedUser.FirstName} {loggedUser.LastName}");
                    Console.WriteLine();
                    if (loggedUser.Role == Roles.JobProvider)
                    {
                        menu = new JobPortal();
                        menu.DisplayMenu();
                    }
                    else if (loggedUser.Role == Roles.JobSeeker)
                    {
                        menu = new JbSeekerManager(loggedUser);
                        menu.DisplayMenu();
                    }
                }
                else
                {
                    Console.WriteLine("Login Failed, Please try again");
                    showmenuUser();
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
                Console.WriteLine("Enter your email Address");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatExceptions("THe email format is not in proper format :" + email);
                return email;
            }
            catch (InvalidFormatExceptions ex)
            {
                Console.WriteLine(ex.Message, "\n");
                Console.WriteLine("Try Again....");
                return GetEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "\n");
                return GetEmail();
            }
        }
        private long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Enter yourPhone Number");
                long phone = long.Parse(Console.ReadLine());
                return phone;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhoneNumber();
            }
        }
        public void RegisterProviderorSeeker()
        {
            try
            {
                User newuser = new User();
                Console.WriteLine("Enter  Id :");
                newuser.Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your FirstName :");
                newuser.FirstName = Console.ReadLine();

                Console.WriteLine("Enter your LastName :");
                newuser.LastName = Console.ReadLine();

                newuser.Email = GetEmail();

                Console.WriteLine("Enter Password :");
                newuser.Password = Console.ReadLine();

                newuser.PhoneNumber = GetPhoneNumber();

                Console.WriteLine("Select your Role");
                Console.WriteLine("1. Job Provider");
                Console.WriteLine("2. Job Seeker");

                string role = Console.ReadLine();
                if (role == "1")
                {
                    newuser.Role = Roles.JobProvider;
                    userRepository.register(newuser);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Job Provider added successfully");
                    Console.WriteLine();
                    
                }
                else if (role == "2")
                {
                    newuser.Role = Roles.JobSeeker;
                    userRepository.Registerseeker(newuser);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Job Seeker added successfully");
                    Console.WriteLine();
                    showmenuUser();
                    
                   
                }
                else
                {
                    Console.WriteLine("Invalid Role selected");
                    return;
                }
                Console.WriteLine();
               
            }

            catch (UserAlreadyExitsException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }


        }
    }
}
    

