using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Excercise.Interface;
using Excercise.Model;
using Excercise.Repository;

namespace Excercise.Manager
{
    public class JobSeekerManager :IMenu 
    {
        IJobInterface jobInterface = new JobRepository();
        IInterviewInterface interviewInterface = new InterviewRepository();
        IUserInterface userInterface = new UserRepository();
        public void DisplayMenu()
        {
            string choice, option;
            try
            {
                do
                {
                    Console.WriteLine("1. List all Jobs");
                    Console.WriteLine("2. Save Jobs");
                    Console.WriteLine("3. Applied Jobs");
                    Console.WriteLine("4. My profile");
                    Console.WriteLine("5. Logout");
                    Console.WriteLine("6. Show saved jobs list");
                    Console.WriteLine("7. Show applied jobs list");
                    Console.WriteLine("Enter your choice....");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            {
                                jobInterface.listJobs();
                                break;
                            }
                        case "2":
                            {
                                Jobs job = new Jobs();
                                User user = new User();
                               savedJobs(job,user);
                                break;
                            }
                        case "3":
                            {
                                Jobs job = new Jobs();
                                User user = new User();
                                appliedJobs(job,user);
                                break ;
                            }
                        case "4":
                            {
                                Console.WriteLine("Profile");
                                Console.WriteLine("::::::::::::::::::::::::");
                                userInterface.show_UserProfile();
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Logging out.......");
                                break ;
                            }
                        case "6":
                            {
                                jobInterface.showsavedJobs();
                                break;
                            }
                        case "7":
                            {
                                jobInterface.showappliedJobs();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice");
                                break;
                            }
                    }
                    Console.WriteLine("Do you wish to continue...(y/n)..?");
                    choice = Console.ReadLine();
                }while(choice == "y" ||  choice == "Y");
            }
            catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
        }

     

        public void savedJobs(Jobs job , User user)
        {
            
            string ch;
            do
            {
                Console.WriteLine("Enter the Job Id");
                int jobid = Convert.ToInt32(Console.ReadLine());
                Jobs saveJobs = jobInterface.findJob(jobid);
                User user_logged = userInterface.getLoggedUser();
                jobInterface.saveJobs(saveJobs, user_logged);
                Console.WriteLine("Do you want to save more jobs.. (y/n) ?");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");

        

        }
        public void appliedJobs(Jobs job , User user)
        {
            string ch;
            do
            {
                Console.WriteLine("Enter the job Id");
                int job_id = Convert.ToInt32(Console.ReadLine());
                Jobs applyJobs = jobInterface.findJob(job_id);
                User logged_user = userInterface.getLoggedUser();
                jobInterface.applyJobs(applyJobs, logged_user);
                Console.WriteLine("Do you wish to apply more jobs...(y/n)..?");
                ch = Console.ReadLine();
            }while(ch == "y" || ch == "Y");
        }


    }
}
