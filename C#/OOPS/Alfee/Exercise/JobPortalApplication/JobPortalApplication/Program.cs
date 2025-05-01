using System;
using JobPortalApplication.Enums;
using JobPortalApplication.Managers;
using JobPortalApplication.Models;

namespace JobPortalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new JobPortalManager();
            var printer = new Printer();

            while (true)
            {
                Console.WriteLine("\n=== Job Portal ===");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Post Job");
                Console.WriteLine("4. View Jobs");
                Console.WriteLine("5. Schedule Interview");
                Console.WriteLine("6. View Interviews");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var newUser = new User();
                        Console.Write("First Name: "); newUser.FirstName = Console.ReadLine();
                        Console.Write("Last Name: "); newUser.LastName = Console.ReadLine();
                        Console.Write("Email: "); newUser.Email = Console.ReadLine();
                        Console.Write("Phone: "); newUser.Phone = Console.ReadLine();
                        Console.Write("Password: "); newUser.Password = Console.ReadLine();
                        newUser.Role = Roles.Applicant;
                        manager.Register(newUser);
                        Console.WriteLine("Registration successful.");
                        break;

                    case "2":
                        Console.Write("Email: ");
                        var email = Console.ReadLine();
                        Console.Write("Password: ");
                        var pass = Console.ReadLine();
                        if (manager.Login(email, pass))
                            Console.WriteLine("Login successful!");
                        else
                            Console.WriteLine("Invalid credentials.");
                        break;

                    case "3":
                        var job = new Job();
                        Console.Write("Job Title: "); job.Title = Console.ReadLine();
                        Console.Write("Description: "); job.Description = Console.ReadLine();
                        Console.Write("Location: "); job.Location = Console.ReadLine();
                        Console.Write("Salary: "); job.Salary = Console.ReadLine();
                        Console.Write("Type (Full-time/Part-time): "); job.Type = Console.ReadLine();
                        Console.Write("Company: "); job.Company = Console.ReadLine();
                        job.Id = new Random().Next(1000, 9999);
                        manager.PostJob(job);
                        Console.WriteLine("Job posted.");
                        break;

                    case "4":
                        var allJobs = manager.GetJobs();
                        printer.Print(allJobs);
                        break;

                    case "5":
                        var interview = new Interview();
                        Console.Write("Company: "); interview.Company = Console.ReadLine();
                        Console.Write("Post: "); interview.Post = Console.ReadLine();
                        Console.Write("Date: "); interview.Date = Console.ReadLine();
                        Console.Write("Time: "); interview.Time = Console.ReadLine();
                        Console.Write("Location: "); interview.Location = Console.ReadLine();
                        interview.Id = new Random().Next(1000, 9999);
                        manager.ScheduleInterview(interview);
                        Console.WriteLine("Interview scheduled.");
                        break;

                    case "6":
                        var interviews = manager.GetInterviews();
                        printer.Print(interviews);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}