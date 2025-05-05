using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Interface;
using JobProvider.Models;
using JobProvider.Repository;

namespace JobProvider.Manaager
{
    internal class JbSeekerManager : IMenu
    {
       public static JobRepository jobRepository= new JobRepository();
       
        private User loggedUser  ;

        private Dictionary<int, List<Job>> SavedJobs = new Dictionary<int, List<Job>>();
        private Dictionary<int, List<Job>> AppliedJob = new Dictionary<int, List<Job>>();

        
        

        public JbSeekerManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            showSeekerMenu();
        }
        public void showSeekerMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. List all Jobs");
            Console.WriteLine("2. Saved Job");
            Console.WriteLine("3. Applied Job");
            Console.WriteLine("4. My Profile");
            Console.WriteLine("5. Logout");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                   List<Job> jobs = jobRepository.GetJobs();
                    Lists lists = new Lists();
                    lists.Print(jobs);
                    ListJobMenu();
                    break;
                case "2":
                   DisplaySavedJob();
                    break;
                case "3":
                    DisplayAppliedJob();
                    break;
                case "4":
                    ViewProfile(loggedUser);
                    showSeekerMenu();
                    break;
                case "5":
                    loggedUser = new User();
                    Console.WriteLine("----------LogOut Successsfully-------- ");
                    return;
                default:
                    Console.WriteLine("Invalid option, try again");
                    break;
            }
        }
        public void ListJobMenu()
        {
            Console.WriteLine("1. Apply Job");
            Console.WriteLine("2. Save Job");
            Console.WriteLine("3. Back to main menu");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ApplyJob();
                    
                    break;
                case "2":
                    SaveJob();
                   
                    break;
                    case "3":
                    Console.WriteLine("Back to main menu");
                    return ;
                    default:
                    Console.WriteLine("Invalid option");
                    break ;
            }
        }
        public void ApplyJob() {
            Console.WriteLine("Enter the id of job you want to apply for : \n");
            int jobid = Convert.ToInt32(Console.ReadLine());

            var selectedid = jobRepository.GetJobById(jobid);
            if (selectedid != null)
            {
                if (!AppliedJob.ContainsKey(loggedUser.Id))
                {
                    AppliedJob[loggedUser.Id] = new List<Job>();
                }
                AppliedJob[loggedUser.Id].Add(selectedid);
                Console.WriteLine($"You have successfully applied for job : as {selectedid.Title} in {selectedid.Company} at {selectedid.Location}");
            }
            else
            {
                Console.WriteLine("Invalid JobId, Please enter valid ID");
            }
            showSeekerMenu();
        }
        public void SaveJob() {
            Console.WriteLine("Enter the JobId you want to save for :");
            int jid = Convert.ToInt32(Console.ReadLine());

            var savejobId = jobRepository.GetJobById(jid);
            if (savejobId != null)
            {
                if (!SavedJobs.ContainsKey(loggedUser.Id))
                {
                    SavedJobs[loggedUser.Id] = new List<Job>();
                }
                SavedJobs[loggedUser.Id].Add(savejobId);
                Console.WriteLine($"You have successfully saved job : {savejobId.Title} at {savejobId.Company}");
            }
            else
            {
                Console.WriteLine("Invalid JOBID, please enter valid id");
            }
            showSeekerMenu();
        }
        public void ViewProfile( User LoggedUser)
        {
           
            if (LoggedUser == null)
            {
                Console.WriteLine("No JobSeeker currently logged in");
                return ;
            }
            {
                Console.WriteLine("-------------------------------------------------------MY PROFILE------------------------------------------------------");
                Console.WriteLine($" Name : {loggedUser.FirstName} {loggedUser.LastName}");
                Console.WriteLine($"Email : {loggedUser.Email}");
                Console.WriteLine($"Phone Number : {loggedUser.PhoneNumber}");
                Console.WriteLine($"Role : {loggedUser.Role}");
                Console.WriteLine("----------------------------------------");

            }
        }
        public void DisplaySavedJob()
        {
            if (SavedJobs.ContainsKey(loggedUser.Id) && SavedJobs[loggedUser.Id].Any())
            {

                Console.WriteLine("Jobs you have Saved \n");
                foreach (var job in SavedJobs[loggedUser.Id])
                {
                    Console.WriteLine($"Job ID : {job.Id}, Title : {job.Title}, Company : {job.Company}, Location : {job.Location}");
                }
            }
            else
            {
                Console.WriteLine("No Jobs saved yet");
            }
            showSeekerMenu();
        }
        public void DisplayAppliedJob()
        {
            if (AppliedJob.ContainsKey(loggedUser.Id) && AppliedJob[loggedUser.Id].Any())
            {

                Console.WriteLine("Displaying Job you have applied for");
                foreach (var jobs in AppliedJob[loggedUser.Id])
                {
                    Console.WriteLine($"Job ID : {jobs.Id}, Title : {jobs.Title}, Company : {jobs.Company}, Location : {jobs.Location}");
                }
            }
            else
            {
                Console.WriteLine("No Jobs Applied yet");
            }
            showSeekerMenu();
        }
    }
}
