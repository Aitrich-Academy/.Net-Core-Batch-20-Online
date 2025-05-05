using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Interface;
using JobProvider.Models;
using JobProvider.Repository;


namespace JobProvider.Manaager
{
    internal class JobPortal : IMenu
    {
      public static JobRepository jobRepository = new JobRepository();

        User LoggedUser;
      
        PublicManager menu;

       
        public void DisplayMenu()
        {
            showMenuJobss();
        }
        public void showMenuJobss()
        {
            Console.WriteLine("Choose an Option");
            Console.WriteLine("1. Jobs");
            Console.WriteLine("2. LogOut");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    JobMenu();
                    break;
                case "2":
                    Console.WriteLine("Logout Successfully...........Exiting the portal....GoodBye");
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        public void JobMenu()
        {
            Console.WriteLine("Choose any option");
            Console.WriteLine("1. List Jobs");
            Console.WriteLine("2. Post Job");
            Console.WriteLine("3. Back to main menu");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ListJob();
                   
                    break;
                case "2":
                    PostJob();
                    break;
                case "3":
                    showMenuJobss();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    showMenuJobss();
                    break;
            }
        }
        public void ListJob()
        {
            List<Job> jobs = jobRepository.GetJobs();
            Lists lists = new Lists();
            lists.Print(jobs);
            JobMenu();
        }
        public void PostJob()
        {
            Console.WriteLine("Enter Job Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Job Title : ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Job Description : ");
            string descrip = Console.ReadLine();

            Console.WriteLine("Enter Job Locatiom : ");
            string location = Console.ReadLine();

            Console.WriteLine("Enter Job Type : ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter Job salary :");
            string salary = Console.ReadLine();

            Console.WriteLine("Enter Job Company : ");
            string company = Console.ReadLine();

            Job job = new Job(id,title,descrip,location,type,salary,company);
           jobRepository.PostJob(job);
         
            Console.WriteLine("------------Job Posted Successfully------------");
            JobMenu();
        }
      
    }
}
