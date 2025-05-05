using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Jobportal.Enums;
using Jobportal.Exceptions;
using Jobportal.Interfaces;
using Jobportal.Models;
using Jobportal.Repository;

namespace Jobportal.Manager
{
    public class Publicmanager : Imenu
    {

        private Userrepository userrepository =new Userrepository();
        public User loggeduser = new User();
        private bool isLoggedIn = false;
        static Imenu menu;

        public void Displaymenu()
        {
            showusermenu();
        }

        private void showusermenu()
        {
            bool exitpgrm = false;
            while (!exitpgrm)
            {
                Console.WriteLine("\n1.Register");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        registerjobseeker();
                        break;

                    case "2":
                        login();
                        if (isLoggedIn)
                        {
                            menu = new Usermanager();
                            menu.Displaymenu();
                        }
                        break;

                    case "3":
                        exitpgrm = true;
                        Console.WriteLine("Exiting.....");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!!!");
                        break;

                }
            }

        }


        public void registerjobseeker()
        {
            try
            {
                User newjobseeker = new User();

                Console.WriteLine("Enter your FirstName: ");
                newjobseeker.Firstname = Console.ReadLine();
                Console.WriteLine("Enter your LastName: ");
                newjobseeker.Lastname = Console.ReadLine();

                newjobseeker.Email = Getemail();
                Console.WriteLine("Enter Password: ");
                newjobseeker.Password = Console.ReadLine();
                Console.WriteLine("Enter your PhoneNumber:");
                newjobseeker.Phone = Convert.ToInt32(Console.ReadLine());
                userrepository.register(newjobseeker);
                Console.WriteLine("Successfully Registerd\n");
               

            }
            
            catch (UserAlreadyexist ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string Getemail()
        {
            try
            {
                Console.WriteLine("Enter you Email: ");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new Invalidformat($"Email {email} was not in correct format!!!");
                return email;
            }
            catch (Invalidformat e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again");
                return Getemail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Getemail();
            }
        }


        public void login()
        {
            try
            {
                string email = Getemail();
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();
                loggeduser = userrepository.login(email, password);
                if (loggeduser != null)
                {
                    Console.WriteLine("Successfully logined");
                    isLoggedIn = true;
                    Console.WriteLine($"Welcome {loggeduser.Firstname} ");
                    if (loggeduser.roles == Role.Seeker)
                    {
                        menu = new Usermanager(loggeduser);
                    }
                    else if (loggeduser.roles == Role.Admin)
                    {
                        menu = new Adminmanager();
                    }
                    menu.Displaymenu();


                }
                else
                {
                    Console.WriteLine("Login Failed!!!!,Try again");
                    Displaymenu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
