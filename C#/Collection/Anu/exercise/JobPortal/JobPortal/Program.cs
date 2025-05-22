using System;
using JobPortal.Enums;
using JobPortal.Managers;
using JobPortal.Models;
using JobPortal.Print;
using JobPortal.Repositories;
using JobPortal.Interfaces;

namespace JobPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize repositories
            var userManager = new UserManager();
            var jobRepository = new JobRepository();
            var applicationRepository = new ApplicationRepository();

            // Initialize managers
            var jobManager = new JobManager(jobRepository);
            var applicationManager = new ApplicationManager(applicationRepository);

            while (true)
            {
                DisplayHelper.ShowMainMenu();
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Handle Login
                        Console.Write("Enter username: ");
                        var username = Console.ReadLine();
                        Console.Write("Enter password: ");
                        var password = Console.ReadLine();

                        try
                        {
                            var user = userManager.Login(username, password);
                            if (user.Role == UserRole.JobProvider)
                            {
                                JobProviderMenu(user as JobProvider, jobManager, applicationManager);
                            }
                            else if (user.Role == UserRole.Applicant)
                            {
                                ApplicantMenu(user as Applicant, jobManager, applicationManager);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case "2":
                        // Handle Registration
                        Console.Write("Enter full name: ");
                        var fullName = Console.ReadLine();
                        Console.Write("Enter username: ");
                        var newUsername = Console.ReadLine();
                        Console.Write("Enter password: ");
                        var newPassword = Console.ReadLine();
                        Console.Write("Enter role (1 for Applicant, 2 for Job Provider): ");
                        var roleInput = Console.ReadLine();

                        UserRole role;
                        if (roleInput == "1")
                            role = UserRole.Applicant;
                        else if (roleInput == "2")
                            role = UserRole.JobProvider;
                        else
                        {
                            Console.WriteLine("Invalid role selection.");
                            break;
                        }

                        try
                        {
                            userManager.Register(newUsername, newPassword, fullName, role);
                            Console.WriteLine("Registration successful!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case "3":
                        // Exit Application
                        Console.WriteLine("Exiting application. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void JobProviderMenu(JobProvider provider, JobManager jobManager, ApplicationManager applicationManager)
        {
            while (true)
            {
                DisplayHelper.ShowJobProviderMenu(provider.FullName);
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Jobs Menu
                        while (true)
                        {
                            Console.WriteLine("1. Post Job");
                            Console.WriteLine("2. List Jobs");
                            Console.WriteLine("3. Back to Job Provider Menu");
                            Console.Write("Enter your choice: ");
                            var jobChoice = Console.ReadLine();

                            if (jobChoice == "1")
                            {
                                // Post Job
                                Console.Write("Enter job title: ");
                                var title = Console.ReadLine();
                                Console.Write("Enter job description: ");
                                var description = Console.ReadLine();

                                var job = new Job
                                {
                                    Title = title,
                                    Description = description,
                                    ProviderUsername = provider.Username
                                };

                                jobManager.PostJob(job);
                                Console.WriteLine("Job posted successfully!");
                            }
                            else if (jobChoice == "2")
                            {
                                // List Jobs
                                var jobs = jobManager.ListJobsByProvider(provider.Username);
                                foreach (var job in jobs)
                                {
                                    Console.WriteLine($"ID: {job.Id}, Title: {job.Title}, Description: {job.Description}");
                                }
                            }
                            else if (jobChoice == "3")
                            {
                                // Back to Job Provider Menu
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                            }
                        }
                        break;

                    case "2":
                        // View Applications
                        var allJobs = jobManager.ListJobsByProvider(provider.Username);
                        foreach (var job in allJobs)
                        {
                            var applications = applicationManager.GetApplicationsByJob(job.Id);
                            Console.WriteLine($"Applications for Job ID {job.Id} - {job.Title}:");
                            foreach (var app in applications)
                            {
                                Console.WriteLine($"Applicant: {app.ApplicantUsername}, Cover Letter: {app.CoverLetter}");
                            }
                        }
                        break;

                    case "3":
                        // Interviews Menu
                        while (true)
                        {
                            Console.WriteLine("1. Schedule Interview");
                            Console.WriteLine("2. List Interviews");
                            Console.WriteLine("3. Back to Job Provider Menu");
                            Console.Write("Enter your choice: ");
                            var interviewChoice = Console.ReadLine();

                            if (interviewChoice == "1")
                            {
                                // Schedule Interview
                                Console.WriteLine("Feature not implemented yet.");
                            }
                            else if (interviewChoice == "2")
                            {
                                // List Interviews
                                Console.WriteLine("Feature not implemented yet.");
                            }
                            else if (interviewChoice == "3")
                            {
                                // Back to Job Provider Menu
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. Please try again.");
                            }
                        }
                        break;

                    case "4":
                        // Exit to Main Menu
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ApplicantMenu(Applicant applicant, JobManager jobManager, ApplicationManager applicationManager)
        {
            while (true)
            {
                DisplayHelper.ShowApplicantMenu(applicant.FullName);
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // List All Jobs
                        var jobs = jobManager.ListAllJobs();
                        foreach (var job in jobs)
                        {
                            Console.WriteLine($"ID: {job.Id}, Title: {job.Title}, Description: {job.Description}");
                        }
                        break;

                    case "2":
                        // Saved Jobs
                        Console.WriteLine("Feature not implemented yet.");
                        break;

                    case "3":
                        // Applied Jobs
                        var applications = applicationManager.GetApplicationsByApplicant(applicant.Username);
                        foreach (var app in applications)
                        {
                            Console.WriteLine($"Applied to Job ID: {app.JobId}, Cover Letter: {app.CoverLetter}");
                        }
                        break;

                    case "4":
                        // My Profile
                        Console.WriteLine($"Username: {applicant.Username}");
                        Console.WriteLine($"Full Name: {applicant.FullName}");
                        break;

                    case "5":
                        // Logout to Main Menu
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
