using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Interfaces;
using Admin.Models;
using Admin.Repository;

namespace Admin.Manager
{
    public class Adminmanager : IMenu
    {
        IJobprovider jobs = new Jobmanager();
        private User loggeduser;
        private UserRepository admins= new UserRepository();
        private Lists display= new Lists();

        public Adminmanager(User loggeduser)
        {
            this.loggeduser = loggeduser;
        }

        public void Displaymenu()
        {
            Showadminmenu();

        }

        public void Showadminmenu()
        {
            Console.WriteLine("\n1. List All Admins");
            Console.WriteLine("2. My profile");
            Console.WriteLine("3. Post a job");
            Console.WriteLine("4. List all jobs");
            Console.WriteLine("5. Logout");
            Console.WriteLine("Enter a option: ");
            string option=Console.ReadLine();

            switch (option)
            {
                case "1":
                    var users = admins.GetAll();
                    display.print(users);
                    Showadminmenu();
                    break;

                case "2":
                    profile();
                    Showadminmenu();
                    break;

                case "3":
                    Console.WriteLine("\nEnter Job Title: ");
                    string title=Console.ReadLine();
                    Console.WriteLine("Enter Description: ");
                    string description=Console.ReadLine();
                    Console.WriteLine("Enter Location: ");
                    string location=Console.ReadLine();
                    Console.WriteLine("Enter Job Type: ");
                    string type=Console.ReadLine();
                    Console.WriteLine("Enter Company Name: ");
                    string company=Console.ReadLine();
                    Console.WriteLine("Enter Salary: ");
                    string salary=Console.ReadLine();
                    Job job=new Job(title,description,location,salary,type,company);
                    jobs.Postjob(job);
                    Console.WriteLine("Job posted succesfully");
                    Showadminmenu();
                    break;

                case "4":
                    List<Job> Jobs=jobs.GetJobs();
                    display.print(Jobs);
                    Showadminmenu();
                    break;

                case "5":
                    Console.WriteLine("successfully logged out");
                    return;

                default:
                    Console.WriteLine("Invalid choice!!!!");
                    Showadminmenu();
                    break;
            }
        }

        public void profile()
        {
            User loggedusers= admins.getloggeduser();
            Console.WriteLine("----Profile-------");
            Console.WriteLine($"Name: {loggedusers.Firstname + loggedusers.Lastname}");
            Console.WriteLine($"Email: {loggedusers.Email}");
            Console.WriteLine($"Phone: {loggedusers.Phone}");
        }

    }
}
