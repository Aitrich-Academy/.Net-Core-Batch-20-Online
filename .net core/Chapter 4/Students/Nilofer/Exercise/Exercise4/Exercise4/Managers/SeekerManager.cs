using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Interfaces;
using Exercise4.Models;

namespace Exercise4.Managers
{
    internal class SeekerManager:IMenu
    {
        private User loggedUser;
        public SeekerManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        JobManager jobManager = new JobManager();
        UserManager userManager = new UserManager();
        Lists list = new Lists();



        public void DisplayMenu()
        {
            ShowSeekerMenu();
        }

        public void ShowSeekerMenu()
        {
            try
            {
                string choice = "";
                while (choice != "5")
                {
                    Console.WriteLine("Choose an Option");
                    Console.WriteLine("1 - List All Jobs");
                    Console.WriteLine("2 - Saved Jobs");
                    Console.WriteLine("3 - Applied Jobs");
                    Console.WriteLine("4 - My profile");
                    Console.WriteLine("5 - Logout");

                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            List<Job> jobs = jobManager.GetJobs();
                            list.Print(jobs);
                            Console.WriteLine();
                            Console.WriteLine("1 - Apply a Job");
                            Console.WriteLine("2 - Save a Job");
                            Console.WriteLine("3 - Back");
                            Console.WriteLine("Enter an option");
                            string option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    ApplyJob();
                                    break;
                                case "2":
                                    SaveJob();
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid input");
                                    break;
                            }

                            break;
                        case "2":
                            Console.WriteLine("------Saved Jobs--------\n");
                            List<Job> saved = loggedUser.GetSavedJobs();
                            list.Print(saved);

                            break;
                        case "3":
                            Console.WriteLine("-------Applied Jobs------\n");
                            List<Job> applied = loggedUser.GetAppliedJobs();
                            list.Print(applied);
                            break;
                        case "4":
                            Console.WriteLine("-------My Profile---------\n");
                            Console.WriteLine($"Name : {loggedUser.FirstName}  {loggedUser.LastName}");
                            Console.WriteLine($"Email : {loggedUser.Email}");
                            Console.WriteLine($"Phone : {loggedUser.PhoneNo}");
                            Console.WriteLine($"Role : {loggedUser.Role}");
                            Console.WriteLine("-----------------------------\n");
                            break;
                        case "5":
                            userManager.loggedUser = new User();
                            Console.WriteLine("Logged out successfully");
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;

                    }
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        public void ApplyJob()
        {
            try
            {
                Console.WriteLine("Enter Job Id to apply : ");
                int id = Convert.ToInt32(Console.ReadLine());

                List<Job> jobs = jobManager.GetJobs();
               
                var job = jobs.FirstOrDefault(e => e.Id == id);
                if (job == null)
                {
                    Console.WriteLine($"Job with ID {id} does not exist.");
                    return;
                }

                var application= new Application(job.Id,loggedUser.Id,job.Title,job.Description,job.Location,job.Type,job.Salaryrange,job.Company);
                jobManager.AddAppliedJob(application);
                loggedUser.AddAppliedJob(job);


                Console.WriteLine($"You have applied Job with id {id} Successfully");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }

        public void SaveJob()
        {
            try
            {
                Console.WriteLine("Enter Job id to Save :");
                int id = Convert.ToInt32(Console.ReadLine());
                List<Job> jobs= jobManager.GetJobs();
                var job = jobs.FirstOrDefault(e => e.Id == id);
                if (job == null)
                {
                    Console.WriteLine($"Job with ID {id} does not exist.");
                    return;
                }

                loggedUser.AddSavedJob(job);

                Console.WriteLine("Job Saved Successfully");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }


    }
}
