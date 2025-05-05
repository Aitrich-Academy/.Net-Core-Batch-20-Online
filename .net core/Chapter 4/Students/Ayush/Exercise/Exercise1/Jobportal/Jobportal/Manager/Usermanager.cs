using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Enums;
using Jobportal.Interfaces;
using Jobportal.Models;
using Jobportal.Repository;

namespace Jobportal.Manager
{
    public class Usermanager : Imenu
    {
        private User loggedUser;
        private User logged=new User();
        Jobmanager jobs=new Jobmanager();
        Publicmanager publicmanager=new Publicmanager();

        public Usermanager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public Usermanager() { }

        public void Displaymenu()
        {
            jobseekermenu();
        }

        public void jobseekermenu()
        {
            Console.WriteLine("\n1. List all jobs");
            Console.WriteLine("2. My profile");
            Console.WriteLine("3. Logout");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    jobs.Listjobs();
                    jobseekermenu();
                    break;

                case "2":
                    myprofile();
                    jobseekermenu();
                    break;

                case "3":
                    Console.WriteLine("Exiting...");
                    publicmanager.Displaymenu();
                    return;
                   

                default:
                    Console.WriteLine("Invalid choice!!");
                    break;
            }
        }

        public void myprofile()
        {
            Console.WriteLine("---My Profile----");
            if (loggedUser != null)
            {
                Console.WriteLine($"Name: {loggedUser.Firstname + loggedUser.Lastname}");
                Console.WriteLine($"Email: {loggedUser.Email}");
                Console.WriteLine($"Phone: {loggedUser.Phone}");

            }

        }

       
    }
}
