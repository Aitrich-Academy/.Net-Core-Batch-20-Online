using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using project.Models;

namespace project.Utils
{
    public class Printer
    {
        public static void Print(Job[] jobs)
        {
            Console.WriteLine("\n---- All Jobs ----\n");

            bool anyJobFound = false;

            foreach (var job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"Title {job.Title}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine($"Company: {job.Company}");
                    Console.WriteLine($"Location: {job.Location}");
                    Console.WriteLine($"Salary Range: {job.SalaryRange}");
                    Console.WriteLine($"Job Type: {job.JobType}");
                    Console.WriteLine("----------------------------");

                    anyJobFound = true;
                }
            }

            if (!anyJobFound)
            {
                Console.WriteLine("No jobs found.");
            }
        }

        public static void Print(User[] registrations)
        {
            Console.WriteLine("\n---- Registered Users ----\n");

            bool anyUserFound = false;

            foreach (var user in registrations)
            {
                if (user != null)
                {
                    Console.WriteLine($"First Name: {user.FirstName}");
                    Console.WriteLine($"Last Name: {user.LastName}");
                    Console.WriteLine($"Email: {user.Email}");
                    Console.WriteLine($"Phone Number: {user.Phone}");
                    Console.WriteLine($"Role: {user.Role}");
                    Console.WriteLine("----------------------------");

                    anyUserFound = true;
                }
            }

            if (!anyUserFound)
            {
                Console.WriteLine("No registered users found.");
            }
        }
    }
}
