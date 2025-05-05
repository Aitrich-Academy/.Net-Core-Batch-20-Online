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
    public class Adminmanager : Imenu
    {
        private User loggeduser;
        private Jobmanager jobs = new Jobmanager();
        private Userrepository userrepository = new Userrepository();
        Publicmanager publicmanager = new Publicmanager();

        public Adminmanager()
        {
            Displaymenu();
        }

        public void Displaymenu()
        {
            adminmenu();
        }

        public void adminmenu()
        {
            Console.WriteLine("\n1. new registrations");
            Console.WriteLine("2. List all Jobs");
            Console.WriteLine("3. Logout");
            Console.WriteLine("Enter a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    newregistration();
                    adminmenu();
                    break;

                case "2":
                    jobs.Listjobs();
                    adminmenu();
                    break;

                case "3":
                    Console.WriteLine("Exiting...");
                    publicmanager.Displaymenu();
                    return;

                default:
                    Console.WriteLine("Invalid Choice!!!");
                    break;

            }
        }
     public void newregistration()
        {
            var seekers = userrepository.Getall();
            if (seekers.Count == 0)
            {
                Console.WriteLine("no new registration!!!!");
            }
            else
            {
                Console.WriteLine("\n-----New Registrations-----\n");
                foreach (var newuser in seekers)
                {
                    Console.WriteLine($"Name:{newuser.Firstname + newuser.Lastname}");
                    Console.WriteLine($"Email: {newuser.Email}");
                    Console.WriteLine($"Phone: {newuser.Phone}");
                }
            }


        }


    }
}
