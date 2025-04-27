using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Models;
using project.Utils;

namespace project.Managers
{
    public class UserManager
    {
        public int jobcount;
        User loggedInuser = new User();
        Job[] jobs = new Job[10];

        public UserManager(Job[] jobs, int jobCount, User loggedInuser)
        {
            this.jobs = jobs;
            this.jobcount = jobCount;
            this.loggedInuser = loggedInuser;
        }


       


        public void SavedJob()
        {
            Console.WriteLine("\n---- Save a Job ----\n");

             // Display all available jobs first

            Console.Write("Enter the Job Title to save: ");
            string? selectedJobTitle = Console.ReadLine();

            for (int i = 0; i < jobcount; i++)
            {
                if (jobs[i] != null && jobs[i].Title.Equals(selectedJobTitle, StringComparison.OrdinalIgnoreCase))
                {
                    // Check for duplicate saved job
                    for (int j = 0; j < loggedInuser.SavedJobCount; j++)
                    {
                        if (loggedInuser.SavedJobs[j].Title.Equals(selectedJobTitle, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("This job is already saved.");
                            return;
                        }
                    }

                    loggedInuser.SavedJobs[loggedInuser.SavedJobCount++] = jobs[i];
                    Console.WriteLine($"Job '{jobs[i].Title}' saved successfully!");
                    return;
                }
            }

            Console.WriteLine("Job not found. Please check the title and try again.");
        }
       
        public void ViewSavedJobs()
        {
            Console.WriteLine("\n---- Your Saved Jobs ----\n");

            if (loggedInuser.SavedJobCount == 0)
            {
                Console.WriteLine("You have not saved any jobs yet.");
                return;
            }

            for (int i = 0; i < loggedInuser.SavedJobCount; i++)
            {
                Job job = loggedInuser.SavedJobs[i];
                if (job != null)
                {
                    Console.WriteLine($"Job Title: {job.Title}");
                    Console.WriteLine($"Company: {job.Company}");
                    Console.WriteLine($"Location: {job.Location}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine($"Salary Range: {job.SalaryRange}");
                    Console.WriteLine($"Job Type: {job.JobType}");
                    Console.WriteLine("---------------------------");
                }
            }
        }
        public void ApplyForJob()
        {
            Console.WriteLine("\n---- Apply for a Job ----\n");

            Printer.Print(jobs); // Show all jobs first

            Console.Write("Enter the Job Title you want to apply for: ");
            string? selectedJobTitle = Console.ReadLine();

            for (int i = 0; i < jobcount; i++)
            {
                if (jobs[i] != null && jobs[i].Title.Equals(selectedJobTitle, StringComparison.OrdinalIgnoreCase))
                {
                    // Let's assume you track applied jobs in the user class
                    loggedInuser.AppliedJobs[loggedInuser.AppliedJobCount++] = jobs[i];

                    Console.WriteLine($"Successfully applied for '{jobs[i].Title}' at {jobs[i].Company}!");
                    return;
                }
            }

            Console.WriteLine("Job not found. Please check the title and try again.");
        }
      
        public void ViewAppliedJobs()
        {
            Console.WriteLine("\n---- Jobs You Have Applied For ----\n");

            if (loggedInuser.AppliedJobCount == 0)
            {
                Console.WriteLine("You have not applied for any jobs yet.");
                return;
            }

            for (int i = 0; i < loggedInuser.AppliedJobCount; i++)
            {
                Job job = loggedInuser.AppliedJobs[i];
                if (job != null)
                {
                    Console.WriteLine($"Job Title: {job.Title}");
                    Console.WriteLine($"Company: {job.Company}");
                    Console.WriteLine($"Location: {job.Location}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine($"Salary Range: {job.SalaryRange}");
                    Console.WriteLine($"Job Type: {job.JobType}");
                    Console.WriteLine("---------------------------");
                }
            }
        }

    }
}
