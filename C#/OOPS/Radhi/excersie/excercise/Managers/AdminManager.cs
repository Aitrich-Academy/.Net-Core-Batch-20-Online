using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Enums;
using project.Models;

namespace project.Managers
{
     class AdminManager
    {
        
     
        
        public int jobcount;
        Job[] jobs = new Job[10];
        public Job[] GetJobs()
        {
            return jobs;
        }

        public AdminManager( Job[] jobs, int jobCount)
        {
           
            this.jobs = jobs;
            this.jobcount = jobCount;
        }

        public void Listalljobs()
        {
            Job job = new Job();
            Console.WriteLine("enter the jobtitle");
            job.Title = Console.ReadLine();
            Console.WriteLine("Enter the Experience");
            string? input = Console.ReadLine();

            if (Enum.TryParse(input, true, out ExperienceLevels selectedLevel))
            {
                Console.WriteLine($"You selected: {selectedLevel}");
                job.ExperienceLevel = selectedLevel;

            }
            else
            {
                Console.WriteLine("Invalid experience level entered.");
            }

            Console.WriteLine("Enter the Company");
            job.Company = Console.ReadLine();
            Console.WriteLine("Enter location");
            job.Location = Console.ReadLine();
            Console.WriteLine("enter salary Range");
            job.SalaryRange = Console.ReadLine();
            Console.WriteLine("enetr job type");
            job.JobType = Console.ReadLine();
            jobs[jobcount++] = job;


        }
        

    }
}
