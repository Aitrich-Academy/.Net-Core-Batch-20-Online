using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Interface;
using JobProvider.Models;
using JobProvider.Repository;

namespace JobProvider.Manager
{
    public class JobManager:IMenu
    {
        UserRepository userRepository = new UserRepository();
        public User LoggedUser = new User();
        IMenu menu;
        public JobManager()
        {

        }
        private bool _isLogged = false; // To track login status
        
        public void DisplayMenu()
        {
            AuthenticationMenu();
        }
        public void AuthenticationMenu()
        {
            bool exitProgram = false;


            while (!exitProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                string option1 = Console.ReadLine();

                switch (option1)
                {
                    case "1":
                        LoginJobProvider();
                        if (_isLogged)
                            menu.DisplayMenu();
                        break;
                    case "2":
                        RegisterJobProvider();
                        break;
                    case "3":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("invalid option ");
                        break;
                }
            }   
        }
        private void LoginJobProvider()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter  your password: ");
            string password = Console.ReadLine();

            // Simplified login check
            if (email == "alfiyasubair5@gmail.com" && password == "123")
            {
                Console.WriteLine("Login successful!");
                //_isLogged = true;
            }
            else
            {
                Console.WriteLine("Login failed. Try again.");
            }
        }

        private void RegisterJobProvider()
        {
            User newJobProvider = new User();

            Console.WriteLine("Please enter your first name:");
            newJobProvider.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            newJobProvider.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");
            newJobProvider.Email = Console.ReadLine();

            
            newJobProvider.Phone = GetPhoneNumber();


            Console.WriteLine("Please enter a password:");
            newJobProvider.Password = Console.ReadLine();
            // Simulate storing credentials (for now)
            Console.WriteLine("Registration successful!");

            userRepository.register(newJobProvider);

        }
        private long GetPhoneNumber()
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
                return GetPhoneNumber();
            }
        }


    }
}
