 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortalApplication.Managers;
using JobPortalApplication.Models;

namespace JobPortalApplication
{
    public class Program
    {
        static void Main()
        {
         
            var manager = new JobPortalManager();
            User currentUser = null;

            while (true)
            {
                Console.WriteLine("\n=== JOB PORTAL ===");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Register(manager);
                        break;
                    case "2":
                        currentUser = Login(manager);
                        if (currentUser != null) ShowDashboard(currentUser, manager);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void Register(JobPortalManager manager)
        {
            Console.Write("First Name: ");
            var fn = Console.ReadLine();
            Console.Write("Last Name: ");
            var ln = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Phone: ");
            var phone = Console.ReadLine();
            Console.Write("Password: ");
            var pwd = Console.ReadLine();

            Roles role;
            while (true)
            {
                Console.Write("Role (Admin or Candidate): ");
                var roleInput = Console.ReadLine()?.ToLower();
                if (roleInput == "admin") { role = Roles.Admin; break; }
                else if (roleInput == "candidate") { role = Roles.Candidate; break; }
                else Console.WriteLine("Invalid role.");
            }

            var user = new User
            {
                FirstName = fn,
                LastName = ln,
                Email = email,
                Phone = phone,
                Password = pwd,
                Role = role
            };

            manager.Register(user);
            Console.WriteLine("✅ Registration successful!");
        }

        static User Login(JobPortalManager manager)
        {
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Password: ");
            var password = Console.ReadLine();

            var user = manager.Login(email, password);
            if (user == null) Console.WriteLine("❌ Login failed.");
            else Console.WriteLine($"✅ Welcome {user.FirstName} ({user.Role})!");
            return user;
        }

        static void ShowDashboard(User user, JobPortalManager manager)
        {
            while (true)
            {
                Console.WriteLine($"\n--- {user.Role} Dashboard ---");
                if (user.Role == Roles.Admin)
                {
                    Console.WriteLine("1. Post Job");
                    Console.WriteLine("2. View Jobs");
                    Console.WriteLine("3. Schedule Interview");
                    Console.WriteLine("4. View Interviews");
                    Console.WriteLine("0. Logout");
                }
                else
                {
                    Console.WriteLine("1. View Jobs");
                    Console.WriteLine("2. Apply to Job");
                    Console.WriteLine("3. View My Applications");
                    Console.WriteLine("0. Logout");
                }

                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "0") return;

                if (user.Role == Roles.Admin)
                {
                    switch (choice)
                    {
                        case "1": PostJob(manager); break;
                        case "2": ViewJobs(manager); break;
                        case "3": ScheduleInterview(manager); break;
                        case "4": ViewInterviews(manager); break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
                else
                {
                    switch (choice)
                    {
                        case "1": ViewJobs(manager); break;
                        case "2": ApplyToJob(user, manager); break;
                        case "3": ViewApplications(user, manager); break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
            }
        }

        static void PostJob(JobPortalManager manager)
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();
            Console.Write("Description: ");
            var desc = Console.ReadLine();
            Console.Write("Location: ");
            var location = Console.ReadLine();
            Console.Write("Salary: ");
            var salary = Console.ReadLine();
            Console.Write("Type: ");
            var type = Console.ReadLine();
            Console.Write("Company: ");
            var company = Console.ReadLine();

            var job = new Job
            {
                Title = title,
                Description = desc,
                Location = location,
                Salary = salary,
                Type = type,
                Company = company
            };

            manager.PostJob(job);
            Console.WriteLine("✅ Job posted.");
        }

        static void ViewJobs(JobPortalManager manager)
        {
            var jobs = manager.GetJobs();
            foreach (var job in jobs)
            {
                Console.WriteLine($"[{job.Id}] {job.Title} at {job.Company} - {job.Location}");
            }
        }

        static void ScheduleInterview(JobPortalManager manager)
        {
            Console.Write("Company: ");
            var company = Console.ReadLine();
            Console.Write("Post: ");
            var post = Console.ReadLine();
            Console.Write("Date: ");
            var date = Console.ReadLine();
            Console.Write("Location: ");
            var location = Console.ReadLine();
            Console.Write("Time: ");
            var time = Console.ReadLine();

            var interview = new Interview
            {
                Company = company,
                Post = post,
                Date = date,
                Location = location,
                Time = time
            };

            manager.ScheduleInterview(interview);
            Console.WriteLine("✅ Interview scheduled.");
        }

        static void ViewInterviews(JobPortalManager manager)
        {
            var interviews = manager.GetInterviews();
            foreach (var i in interviews)
            {
                Console.WriteLine($"[{i.Id}] {i.Company} - {i.Post} on {i.Date} at {i.Time} in {i.Location}");
            }
        }

        static void ApplyToJob(User user, JobPortalManager manager)
        {
            Console.Write("Enter Job ID to apply: ");
            if (int.TryParse(Console.ReadLine(), out int jobId))
            {
                manager.ApplyToJob(user.Email, jobId);
                Console.WriteLine("✅ Application submitted.");
            }
            else
            {
                Console.WriteLine("❌ Invalid Job ID.");
            }
        }

        static void ViewApplications(User user, JobPortalManager manager)
        {
            var apps = manager.GetApplications(user.Email);
            if (apps.Length == 0)
            {
                Console.WriteLine("No applications yet.");
                return;
            }

            foreach (var app in apps)
            {
                Console.WriteLine($"Applied to Job ID: {app.JobId}");
            }
        }
    }
    }

