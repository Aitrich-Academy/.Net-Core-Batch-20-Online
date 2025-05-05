using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exercise4.Interfaces;
using Exercise4.Models;
using Exercise4.Repository;
using Exercise4.Exceptions;
using Exercise4.Enums;

namespace Exercise4.Managers
{
    internal class UserManager:IMenu
    {
        IMenu menu;
        UserRepository userRepository = new UserRepository();
        public User loggedUser;

        public void DisplayMenu()
        {
            
                ShowUserMenu();
            
        }

        public void ShowUserMenu()
        {
            bool exit = false;
            while (!exit)
            {

                

                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - Register");
                Console.WriteLine("2 - Login");
                Console.WriteLine("3 - Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Register();

                        break;
                    case "2":
                        Login();

                        break;
                    case "3":
                        Console.WriteLine("Exiting");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");

                    break;
                }
            }

        }

        public void Register()
        {
            try
            {
                User newUser = new User();
                Console.WriteLine("Enter First Name :");
                newUser.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                newUser.LastName = Console.ReadLine();
                newUser.Email = GetEmail();
                newUser.PhoneNo = GetPhone();
                Console.WriteLine("Enter Password : ");
                newUser.Password = Console.ReadLine();
                Console.WriteLine("Enter Role (JobSeeker/ JobProvider)");
                string roleinput = Console.ReadLine();
                Roles role;
                Enum.TryParse(roleinput, true, out role);
                newUser.Role = role;

                bool isReistered = userRepository.Register(newUser);

                if (isReistered)
                {
                    Console.WriteLine("Registered Successfully You can Login now");
                }


            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                throw new InvalidEmailException("Invalid email");
            }
            catch (InvalidEmailException ex)
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

        public long GetPhone()
        {
            try
            {
                Console.WriteLine("Please enter your phone number:");
                long Phone = long.Parse(Console.ReadLine());
                return Phone;
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhone();
            }
        }

        public void Login()
        {
            try
            {
                Console.WriteLine("Enter Email : ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                string password = Console.ReadLine();
                loggedUser = userRepository.Login(email, password);
                
                if(loggedUser != null)
                {
                    Console.WriteLine("Login Successfull");
                    Console.WriteLine($"Welcome {loggedUser.FirstName}");

                    if(loggedUser.Role == Roles.JobSeeker)
                    {
                        menu = new SeekerManager(loggedUser);
                        menu.DisplayMenu();
                    }
                    else if(loggedUser.Role == Roles.JobProvider)
                    {
                        menu = new ProviderManager();
                        menu.DisplayMenu();
                    }
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}
