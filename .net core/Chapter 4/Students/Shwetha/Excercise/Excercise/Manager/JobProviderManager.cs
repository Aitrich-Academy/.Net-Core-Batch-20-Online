using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Interface;
using Excercise.Model;
using Excercise.Repository;

namespace Excercise.Manager
{
    public class JobProviderManager:IMenu 
    {
        IJobInterface jobInterface = new JobRepository();
        IInterviewInterface interviewInterface = new InterviewRepository();
    
        public void DisplayMenu()
        {
            string choice, option;
            try
            {
                do
                {
                    Console.WriteLine("1. Jobs");
                    Console.WriteLine("2. Applications");
                    Console.WriteLine("3. Interviews");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice......");
                    option = Console.ReadLine();
                    switch(option)
                    {
                        case "1":
                            {
                                string ch, opt;
                                do
                                {
                                    Console.WriteLine("1. List Jobs");
                                    Console.WriteLine("2. Post Jobs");
                                    Console.WriteLine("3. Back to main menu...");
                                    Console.WriteLine("enter your choice.....");
                                    ch = Console.ReadLine();
                                    switch (ch)
                                    {
                                        case "1":
                                            {
                                                jobInterface.listJobs();
                                                break;
                                            }
                                        case "2":
                                            {
                                                postJob();
                                                break;
                                            }
                                        case "3":
                                            {
                                                Console.WriteLine("Exiting.....");
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid choice");
                                                break;
                                            }
                                    }
                                    Console.WriteLine("Do you wish to continue...(y/n)...!");
                                    opt = Console.ReadLine();
                                }
                                while (opt == "y" || opt == "Y");
                                break;
                            }
                        case "2":
                            {
                                applications();
                                break;
                            }
                        case "3":
                            {
                                string ch, opt;
                                do
                                {
                                    Console.WriteLine("1. List Interview");
                                    Console.WriteLine("2. Schedule Interview");
                                    Console.WriteLine("3. Back to main menu....");
                                    Console.WriteLine("Enter your choice...");
                                    ch= Console.ReadLine();
                                    switch(ch)
                                    {
                                        case "1":
                                            {
                                               interviewInterface.listInterview();
                                                break;
                                            }
                                        case "2":
                                            {
                                                scheduleInterview();
                                                break;
                                            }
                                        case"3":
                                            {
                                                Console.WriteLine("Exiting...");
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid choice");
                                                break;
                                            }
                                    }
                                    Console.WriteLine("Do you wish to continue...(y/n)");
                                    opt= Console.ReadLine();
                                }while(opt == "y" || opt == "Y");
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Exiting....... \n Good Bye");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice");
                                break;
                            }
                    }
                    Console.WriteLine("Do you wish to continue....(y/n).!!");
                    choice = Console.ReadLine();
                }
                while (choice == "y" || choice == "Y");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        
            void applications()
            {
                Console.WriteLine("Enter the job Id");
            }
        
            void scheduleInterview()
            {
                Interview interview_obj = new Interview();
                Console.WriteLine("Enter the Interview Id");
                interview_obj.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Post name");
                interview_obj.Post_Name = Console.ReadLine();
                Console.WriteLine("Post Description");
                interview_obj.Date = Console.ReadLine();
                Console.WriteLine("Interview location");
                interview_obj.Location = Console.ReadLine();
                interviewInterface.scheduleInterview(interview_obj);
                
            }
           
        }
        public void postJob()
        {
            Jobs jobs_object = new Jobs();
            Console.WriteLine("Enter the job Id");
            jobs_object.JobId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the job Name");
            jobs_object.JobName = Console.ReadLine();
            Console.WriteLine("Enter the job Salary");
            jobs_object.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the job Type");
            jobs_object.Type = Console.ReadLine();
            Console.WriteLine("Enter the job Location");
            jobs_object.Location = Console.ReadLine();
            jobInterface.postJob(jobs_object);
        }
    }
}
