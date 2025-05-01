using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Enums;
using project.Interfaces;
using project.Models;
using project.Utils;

namespace project.Managers
{
    public class PublicManager:ILogin
    {
        User[] users = new User[10];
        public User[] Users => users;

        User loggedInuser = new User();
        AdminManager adminManager;
        
        int jobCount;
        Job[] jobs = new Job[10];
        UserManager userManager;

        public PublicManager()
        {
            jobs = new Job[10];
            jobCount = 0;
            adminManager = new AdminManager(jobs, jobCount);

            userManager = new UserManager(jobs, jobCount, loggedInuser); // create once here!
        }
        // or get this from somewhere in your project

int usercount;

        public void Logout()
        {
            loggedInuser = new User();
            Console.WriteLine("Logged out successfully!");
            Show_main_menu();
        }
        public void Showadminmenu()
        {
            Console.WriteLine("Welcome Admin page");
            Console.WriteLine("-----------------------");

            Console.WriteLine("1.View All Registration \n2.List All Jobs \n3. View All Jobs \n4.Logout");
            Console.WriteLine();

            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {



                        Printer.Print(users);

                        Showadminmenu();
                        break;

                    }

                case "2":
                    {
                        adminManager.Listalljobs();
                        jobs = adminManager.GetJobs();        // Update the jobs array!
                        jobCount = adminManager.jobcount;     // Update job count

                        Showadminmenu();

                       

                        break;
                    }
                case "3":
                    {

                        Printer.Print(jobs);
                        Showadminmenu();
                        break;
                    }
                case "4":
                    {
 
                        Logout();
                        break;

                    }
            }
        }
        public void Show_main_menu()
        {
            Console.WriteLine("Welcome to the Jobportal");
            Console.WriteLine("_______________________________");
            Console.WriteLine("1.Login \n2.Registration");

            string? choice = Console.ReadLine();

            switch (choice)

            {
                case "1":
                    {
                        Console.WriteLine("Please enter your email:");

                        string? email = Console.ReadLine();

                        Console.WriteLine("Please enter your password:");
                        string? password = Console.ReadLine();

                        bool loginRes = Login(email,password);
                        if (loginRes)
                        {


                            Console.WriteLine($" Welcome {loggedInuser.FirstName} {loggedInuser.LastName}");
                            Console.WriteLine($"Your role is: {loggedInuser.Role}");
                            Console.WriteLine("________________________");
                            if (loggedInuser.Role == Enums.Roles.Admin)
                            {
                                Showadminmenu();
                            }
                            else
                            {
                                Showseekermenu();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Login failed...!");


                            Show_main_menu();
                        }
                        break;
                    }
                case "2":
                    {
                        UserRegister();
                        break;
                    }


                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Show_main_menu();
                    break;
            }


        }
        public void Showseekermenu()
        {
            Console.WriteLine("Welcome Jobseeker page");
            Console.WriteLine("********************************");
            Console.WriteLine("1.view and apply job \n2.View Applied Job \n3.View saved jobs \n4.Logout");

            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":

                    {
                        Seekermenu();
                        break;
                    }
                case "2":
                    {

                        UserManager userManager = new UserManager(jobs, jobCount, loggedInuser);

                        userManager.ViewAppliedJobs();
                        Seekermenu();

                        break;
                    }
                case "3":
                    {

                        UserManager userManager = new UserManager(jobs, jobCount, loggedInuser);

                        userManager.ViewSavedJobs();
                        Seekermenu();

                        break;
                    }
                case "4":
                    {
                        Logout();
                        break;

                    }
                default:
                    {
                        Console.WriteLine("invalid entry");
                        break;
                    }
            }
        }
        public void Seekermenu()
        {
            Console.WriteLine("__________________");
            Console.WriteLine("1.View All Job \n2.Apply for Job \n3.save Job \n4.Back To Main Menu ");

            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Printer.Print(jobs);
                        Seekermenu();
                        break;

                    }
                case "2":
                    {
                        UserManager userManager = new UserManager(jobs, jobCount, loggedInuser);

                        userManager.ApplyForJob();
                        Seekermenu();
                        break;                   

                    }
                case "3":
                    {

                        UserManager userManager = new UserManager(jobs, jobCount, loggedInuser);

                        userManager.SavedJob();
                        Seekermenu();

                        break;
                    }
                case "4":
                    {
                        Showseekermenu();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("enter invalid entry");
                        break;
                    }
            }

        }
        public void UserRegister()
        {

            User newUser = new User();
            Console.WriteLine("Enter your first Name");
            newUser.FirstName = Console.ReadLine();
            Console.WriteLine("enter your Last Name");

            newUser.LastName = Console.ReadLine();
            Console.WriteLine("enter your email");
            newUser.Email = Console.ReadLine();

            Console.WriteLine("rnter your password");
            newUser.Password = Console.ReadLine();

            Console.WriteLine("enter your phonenumber ");
            newUser.Phone = Console.ReadLine();

            Console.WriteLine("enter your role");
            string? input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Roles selectedLevel))
            {
                Console.WriteLine($"You selected: {selectedLevel}");
                newUser.Role = selectedLevel;

            }
            else
            {
                Console.WriteLine("Invalid experience level entered.");
            }
           users[usercount++] = newUser;
            Console.WriteLine("Registration successful");


        }
        public bool Login(string? email, string? password)
        {
            foreach (User user in users)
            {
                if (user != null && user.Email == email && user.Password == password)
                {
                    loggedInuser = user;
                    return true;
                }
            }
            return false;
        }

    }
}
