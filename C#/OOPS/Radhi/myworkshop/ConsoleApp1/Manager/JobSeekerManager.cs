using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobApplication.Enums;
using JobApplication.Models;

namespace JobApplication.Manager
{
    public class JobSeekerManager
    {
        private JobSeeker[] jobSeekers = new JobSeeker[10];
        int jobSeekerCount = 0;
        public JobSeeker loggedInJobSeeker = new JobSeeker();
        public void RegisterJobseeker()
        {
            JobSeeker jobSeeker = new JobSeeker();

            Console.WriteLine("Enter your first Name");
            jobSeeker.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last Name");
            jobSeeker.LastName = Console.ReadLine();


            Console.WriteLine("Please enter your email address:");
            jobSeeker.Email = Console.ReadLine();

            Console.WriteLine("Choose your experience level:");
            foreach (var level in Enum.GetValues(typeof(ExprienceLevels)))
            {
                Console.WriteLine($"- {level}");
            }

            Console.Write("Enter experience level: ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out ExprienceLevels selectedLevel))
            {
                Console.WriteLine($"You selected: {selectedLevel}");
                jobSeeker.ExperienceLevel = selectedLevel;
            }
            else
            {
                Console.WriteLine("Invalid experience level entered.");
            }






            Console.WriteLine("Please enter your phone number:");
            jobSeeker.Phone = Console.ReadLine();

            Console.WriteLine("Please enter your Location");
            jobSeeker.Location = Console.ReadLine();

            Console.WriteLine("Please enter About Me");
            jobSeeker.AboutMe = Console.ReadLine();

            Console.WriteLine("Please enter your Qualification");
            jobSeeker.Qualification = Console.ReadLine();


            Console.WriteLine("Please enter a password:");
            jobSeeker.Password = Console.ReadLine();
            jobSeekers[jobSeekerCount] = jobSeeker;
            jobSeekerCount++;
            

        }

        public bool LoginJobSeeker()
        {
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            bool loginSuccessful = false;
            foreach (JobSeeker seeker in jobSeekers)
            {
                if (seeker != null && seeker.Email == email && seeker.Password == password)
                {
                    loggedInJobSeeker = seeker;
                    loginSuccessful = true;
                    break;
                }
            }

            return loginSuccessful;

        }


        public void ShowJobSeekerMenu()
        {
           

            Console.WriteLine("1. My profile");

            Console.WriteLine("2. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":
                    ViewProfile();
                    ShowJobSeekerMenu();
                    break;
                case "2":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowJobSeekerMenu();
                    break;
            }




        }
        public void ViewProfile()
        {
            Console.WriteLine("************MY PROFILE************\n");
            Console.WriteLine($"First Name: {loggedInJobSeeker.FirstName}");
            Console.WriteLine($"Last Name: {loggedInJobSeeker.LastName}");
            Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            Console.WriteLine($"Phone: {loggedInJobSeeker.Phone}");
            Console.WriteLine($"Location: {loggedInJobSeeker.Location}");
            Console.WriteLine($"AboutMe: {loggedInJobSeeker.AboutMe}");
            Console.WriteLine($"ExperienceLevel: {loggedInJobSeeker.ExperienceLevel}");
            Console.WriteLine("\n");

        }

        public void Logout()
        {
            loggedInJobSeeker = new JobSeeker();
            Console.WriteLine("Logged out successfully!");
            ShowMainMenu();
        }

        public void ShowMainMenu()
        {
            
            Console.WriteLine("Welcome to the job portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterJobseeker();
                    break;
                case "2":
                    bool loginRes = LoginJobSeeker();
                    if (loginRes) 
                    {
                        Console.WriteLine("Welcome " + loggedInJobSeeker.FirstName + "!");
                        ShowJobSeekerMenu();
                    }
                    else
                    {
                        Console.WriteLine("Login failed...!");

                        ShowMainMenu();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowMainMenu();
                    break;
            }
        }


    }
}


