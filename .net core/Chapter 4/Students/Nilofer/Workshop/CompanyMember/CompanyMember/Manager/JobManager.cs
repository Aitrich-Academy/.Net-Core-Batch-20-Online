using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Enums;
using CompanyMember.Interfaces;
using CompanyMember.Models;

namespace CompanyMember.Manager
{
    internal class JobManager:IMenu
    {
        private User loggeduser;
        Lists list = new Lists();
        IJobProvider Job = new JobPortal();
        public JobManager(User loggeduser)
        {
            this.loggeduser = loggeduser;
        }

        public void DisplayMenu()
        {
            ShowProviderMenu();
        }

        public void ShowProviderMenu()
        {

            Console.WriteLine("1. Post a  job ");
            Console.WriteLine("2. List all Jobs ");
            Console.WriteLine("3. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    postJob();
                    ShowProviderMenu();
                    break;
                case "2":
                    List<Job> jobs = Job.GetJobs();
                    list.Print(jobs);
                    ShowProviderMenu();
                    break;
                case "3":
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
            Console.Write("Enter required Experience level(Fresher,Midlevel,Senior): ");
            string expr = Console.ReadLine();
            ExperienceLevels level;
            Enum.TryParse(expr, true, out level);

            Console.Write("Enter Job location: ");
            string location = Console.ReadLine();
            Console.Write("Enter Job Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Job salary range: ");
            string salary = (Console.ReadLine());
            Console.Write("Enter Job company: ");
            string company = (Console.ReadLine());
            Job job = new Job(title, level, location, type, salary, company);
            Job.PostJob(job);
            Console.WriteLine("Job posted Successfully...");

        }

        public void Logout()
        {
            loggeduser = new User();
            Console.WriteLine("Logged out successfully!");

        }


    }
}
