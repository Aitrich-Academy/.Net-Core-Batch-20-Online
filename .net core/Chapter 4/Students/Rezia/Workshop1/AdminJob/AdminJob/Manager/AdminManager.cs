using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AdminJob.Interface;
using AdminJob.Models;
using AdminJob.Repository;
using AdminJob.Enums;
using AdminJob.Exceptions;
using AdminJob.Manager;



namespace AdminJob.Manager
{
    internal class AdminManager : IMenu
    {
        IJobProvider Jobs = new JobManager();
        UserRepository Admins = new UserRepository();
        private Lists display = new Lists();
        private User loggedUser;
        public AdminManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }   
        public void DisplayMenu()
        {
            showAdminMenu();
        }
        public void showAdminMenu()
        {
            Console.WriteLine("Welcome to Job  Portal");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1. List all Admins");
            Console.WriteLine("2. My Profile");
            Console.WriteLine("3. Post a Job");
            Console.WriteLine("4. List Job");
            Console.WriteLine("5. LogOut");
            Console.WriteLine("Choose an option");
            Console.WriteLine();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var users = Admins.GetUsers();
                    display.Print(users);
                    showAdminMenu();
                    break;
                case "2":
                    ViewProfile();
                    showAdminMenu();
                    break;
                case "3":
                    Console.WriteLine("Enter the Job Id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Job title : ");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter the Job Description : ");
                    string description = Console.ReadLine();

                    Console.WriteLine("Enter Location : ");
                    string location = Console.ReadLine();

                    Console.WriteLine("Enter Salary : ");
                    string salary = Console.ReadLine();

                    Console.WriteLine("Enter Type : ");
                    string type = Console.ReadLine();

                    Console.WriteLine("Enter Company : ");
                    string company = Console.ReadLine();

                    Job job = new Job(id,title,description,location,salary,type,company);

                    Jobs.PostJob(job);
                    Console.WriteLine("Job Posted Successfully");
                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
                    showAdminMenu();
                    break;
                case "4":
                    Console.WriteLine("List of Job Details : ");
                    Console.WriteLine();
                    List<Job> jobs = Jobs.GetJobs();
                    display.Print(jobs);
                    showAdminMenu();
                    break;
                case "5":
                    loggedUser = new User();
                    Console.WriteLine("Logout successfully");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    showAdminMenu();
                    break;

            }
        }
            public void ViewProfile()
        {
           
            if (loggedUser == null)
            {
                Console.WriteLine("No Admin currently logged in \n");
                return;
            }
            Console.WriteLine("_________________________________MY PROFILE______________________________");
            Console.WriteLine($"FirstName : {loggedUser.FirstName}");
             Console.WriteLine($"LastName : {loggedUser.LastName}");
            Console.WriteLine($"Email ID : {loggedUser.Email}");
            Console.WriteLine($"Phone Number : {loggedUser.Phone}");
            Console.WriteLine($"Role : {loggedUser.Role}");
            Console.WriteLine("\n");

        }
            }
        }
    

