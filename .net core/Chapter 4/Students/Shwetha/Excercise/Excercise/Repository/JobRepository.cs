using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Interface;
using Excercise.Model;
using Microsoft.VisualBasic.FileIO;

namespace Excercise.Repository
{
    public class JobRepository : IJobInterface
    {
        Dictionary<Guid, List<Jobs>> list_of_Jobs = new Dictionary<Guid, List<Jobs>>();
        Dictionary<Guid, List<Jobs>> list_of_applied_jobs = new Dictionary<Guid, List<Jobs>>();
        List<Interview> interviews = new List<Interview>();
        List<Jobs> JobsList = new List<Jobs>();
        private Jobs jobid;

        //{
        //   new Jobs (123, "Python Developer", 130000, "offline"," Banglore"),
        //   new Jobs (142, "Angular Developer", 50000, "online"," Trivandrum")
        //};

        public void postJob(Jobs job)
        {
            JobsList.Add(job);

        }
        public void listJobs()
        {
            Console.WriteLine("List of jobs");
            foreach (var item in JobsList)
            {
                Console.WriteLine("JobID :{0} JobName :{1} Salary :{2} Location :{3}", item.JobId, item.JobName, item.Salary, item.Location);
            }
        }

        public Jobs findJob(int jobid)
        {
            var query = JobsList.Where(e => e.JobId == jobid).FirstOrDefault();
            return query;
        }
        public void applyJobs(Jobs job, User user)
        {
            if (list_of_applied_jobs.ContainsKey(user.Id))
            {
                list_of_applied_jobs[user.Id].Add(job);
            }
            else
            {
                var applylist = new List<Jobs>();
                applylist.Add(job);
                list_of_applied_jobs.Add(user.Id, applylist);
            }
        }
        public void saveJobs(Jobs job, User user)
        {
            if (list_of_Jobs.ContainsKey(user.Id))
            {
                list_of_Jobs[user.Id].Add(job);
            }
            else
            {
                var joblist = new List<Jobs>();
                joblist.Add(job);
                list_of_Jobs.Add(user.Id, joblist);
            }


        }
        public void showsavedJobs()
        {
            Console.WriteLine("Saved Jobs are :");
            Console.WriteLine("::::::::::::::::::::::::");
            Console.WriteLine("Total jobs saved  :{0}",list_of_Jobs.Count );
            foreach(var job in list_of_Jobs)
            {
                Console.WriteLine("User Id  : {0}" ,job.Key);
                foreach(var item in job.Value)
                {
                    Console.WriteLine ("Job Id :{0} Job Name :{1} Location : {2} Salary :{3}  " , item.JobId,item.JobName,item.Location,item.Salary);
                }
            }
        }
        public void showappliedJobs()
        {
            Console.WriteLine("Applied Jobs are :");
            Console.WriteLine("::::::::::::::::::::::::");
            Console.WriteLine("Total jobs Applied  :{0}", list_of_applied_jobs.Count);
            foreach (var job in list_of_applied_jobs)
            {
                Console.WriteLine("User Id  : {0}", job.Key);
                foreach (var item in job.Value)
                {
                    Console.WriteLine("Job Id :{0} Job Name :{1} Location : {2} Salary :{3}  ", item.JobId, item.JobName, item.Location, item.Salary);
                }
            }
        }
    }
}