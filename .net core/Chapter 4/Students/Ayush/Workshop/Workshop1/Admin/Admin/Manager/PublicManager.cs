using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Admin.Enums;
using Admin.Exceptions;
using Admin.Interfaces;
using Admin.Models;
using Admin.Repository;

namespace Admin.Manager
{
    public class PublicManager : IMenu
    {
        UserRepository userRepository=new UserRepository();
        public User Loggeduser=new User();
        bool islogged=false;
        IMenu menu;

        public void Displaymenu()
        {
            showusermenu();
        }

        private void showusermenu()
        {
            bool exitprogram=false;
            while (!exitprogram)
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Exit");
                Console.WriteLine("Choose an option: ");
                string option=Console.ReadLine();

                switch (option)
                {
                    case "1":
                        loginadmin();
                        if (islogged)
                            menu.Displaymenu();
                        break;

                    case "2":
                        exitprogram = true;
                        Console.WriteLine("Exiting.........");
                        break;

                    default:
                        Console.WriteLine("Invalid option!!!");
                        break;
                }
            }
        }


        public void loginadmin()
        {
            try
            {
                string email = Getemail();
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();
                Loggeduser = userRepository.login(email, password);

                if (Loggeduser != null)
                {
                    Console.WriteLine("Successfully loggedin");
                    islogged = true;
                    Console.WriteLine($"Welcome {Loggeduser.Firstname}");
                    if (Loggeduser.Roles == Roles.Admin)
                    {
                        menu = new Adminmanager(Loggeduser);
                    }
                }
                else
                {
                    Console.WriteLine("Login failed!! ,try again");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string Getemail()
        {
            try
            {
                Console.WriteLine("Enter you Email: ");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
               
                    throw new InvalidFormat($"email '{email}' was not in correct pattern!!");
                    return email;

                
            }
            catch (InvalidFormat ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                return Getemail();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Getemail();

            }
        }

        //private long Getphonenumber()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter you phone number: ");
        //        long phone = long.Parse(Console.ReadLine());
        //        return phone;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Invalid phone number!!");
        //        return Getphonenumber();
        //    }
        //}

    }
}
