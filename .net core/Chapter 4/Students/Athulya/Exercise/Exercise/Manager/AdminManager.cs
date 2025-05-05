using Exercise.Interface;
using Exercise.Model;
using Exercise.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Manager
{
    public class AdminManager : IMenu
    {

        IRepository repository = new UserRepository();
        private User loggedUser;
        JobManager jobs=new JobManager();
        public AdminManager(User loggedUser, JobManager jobs)
        {
            this.loggedUser = loggedUser;
            this.jobs = jobs;
        }

        public AdminManager() { }

        public void DisplayMenu()
        {
            ShowMenu();
            ShowUserMenu();

        }
       
        public void ShowMenu()
        {
            try
            {
                string select, sel;
                Console.WriteLine("Select options");
                Console.WriteLine("1.New Registration");
                Console.WriteLine("2.List of Jobs");
                Console.WriteLine("3.Logout");

                select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                       ListnewRegistration();
                        ShowMenu();

                        break;
                    case "2":
                       jobs.ListJob();
                        ShowMenu();
                        break;
                    case "3":
                        Logout();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        ShowMenu();
                        break;

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void Logout()
        {
            loggedUser = new User();




            Console.WriteLine("Logged out successfully!");

        }

      public void ListnewRegistration()
        {
          
                List<User> users = repository.ListnewRegistration();

                
                if (users != null && users.Count > 0)
                {
                    Console.WriteLine("The registered job seekers are:");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"{"First Name",-15} {"Last Name",-15} {"Email",-25} {"Phone Number",-15}");
                    Console.WriteLine("------------------------------------------------");

                    foreach (User user in users)
                    {
                       
                        Console.WriteLine($"{user.FirstName,-15} {user.LastName,-15} {user.Email,-25} {user.Phone,-15}");
                    }
                }
                else
                {
                   
                    Console.WriteLine("No users are registered.");
                }
            }

     public  void  ShowUserMenu()
        {
            try
            {

                string  sel;
                Console.WriteLine("Select options");
                Console.WriteLine("1.List All Jobs");
                Console.WriteLine("2.My profiles");
                Console.WriteLine("3.Logout");

                sel = Console.ReadLine();

                switch (sel)
                {
                    case "1":
                        jobs.ListJob();
                        ShowUserMenu();
                        break;
                    case "2":

                        Myprofile();
                        ShowUserMenu();
                        break;
                    case "3":
                        Logout();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        ShowUserMenu();
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void Myprofile()
        {
            throw new NotImplementedException();
        }

        //public void MyProfile()
        //{


        //    if (loggedUser != null && !string.IsNullOrEmpty(loggedUser.FirstName))
        //    {
        //        Console.WriteLine("Your Profile:");
        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine($"First Name: {loggedUser.FirstName}");
        //        Console.WriteLine($"Last Name: {loggedUser.LastName}");
        //        Console.WriteLine($"Email: {loggedUser.Email}");
        //        Console.WriteLine($"Phone: {loggedUser.Phone}");
        //        Console.WriteLine("-------------------------------");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No user is currently logged in.");
        //    }
        //}


    }
}

