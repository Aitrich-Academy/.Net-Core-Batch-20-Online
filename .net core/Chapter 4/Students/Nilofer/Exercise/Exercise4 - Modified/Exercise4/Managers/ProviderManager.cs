using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Interfaces;
using Exercise4.Repository;
using Exercise4.Models;
using Exercise4.Enums;

namespace Exercise4.Managers
{
    internal class ProviderManager:IMenu
    {

        JobManager jobManager = new JobManager();
        Lists list = new Lists();
        public ProviderManager() { }

        public void DisplayMenu()
        {
            ShowProviderMenu();
        }

        public void ShowProviderMenu()
        {

            Console.WriteLine("1. Post a  job ");
            Console.WriteLine("2. List all Jobs ");
            Console.WriteLine("3. View All applied Jobs");
            Console.WriteLine("4. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    postJob();
                    ShowProviderMenu();
                    break;
                case "2":
                    List<Job> jobs = jobManager.GetJobs();
                    list.Print(jobs);
                    ShowProviderMenu();
                    break;
                case "3":
                    jobManager.PrintAllappliedJobs();
                    ShowProviderMenu();
                    break;
                case "4":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice.Please try again");
                    ShowProviderMenu();
                    break;

            }
        }

        public void postJob()
        {
            Console.Write("Enter Job title: ");
            string title = Console.ReadLine();
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            
            Console.Write("Enter Job location: ");
            string location = Console.ReadLine();
            Console.Write("Enter Job Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Job salary range: ");
            string salary = (Console.ReadLine());
            Console.Write("Enter Job company: ");
            string company = (Console.ReadLine());
            Job job = new Job(title, description, location, type, salary, company);
            jobManager.PostJob(job);
            Console.WriteLine("Job posted Successfully...");

        }

       


        public void Logout()
        {
            //loggeduser = new User();
            Console.WriteLine("Logged out successfully!");

        }




    }
}
