using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Interfaces;
using Exercise4.Models;

namespace Exercise4.Managers
{
    internal class JobManager:IJobProvider
    {
        public static List<Job> jobs = new List<Job>();

        public static Dictionary<int, List<Job>> appliedJobs = new Dictionary<int, List<Job>>();

        public static Dictionary<int, List<Job>> savedJobs = new Dictionary<int, List<Job>>();





        int Jobid = 1;

        public void PostJob(Job job)
        {
            job.Id = Jobid;
            jobs.Add(job);
            Jobid++;
        }

        public void AddappliedJob(int UserId,Job job)
        {
            if (!appliedJobs.ContainsKey(UserId))
            {
                appliedJobs[UserId] = new List<Job>();
            }
            appliedJobs[UserId].Add(job);

        }

        public void AddSavedJob(int UserId, Job job)
        {
            if (!savedJobs.ContainsKey(UserId))
            {
                savedJobs[UserId] = new List<Job>();
            }
            savedJobs[UserId].Add(job);

        }

        public List<Job> GetApplied(int UserId)
        {
            if (appliedJobs.ContainsKey(UserId))
            {
                return appliedJobs[UserId];
            }
            return new List<Job>();
        }

        public List<Job> GetSaved(int  UserId)
        {
            if (savedJobs.ContainsKey(UserId))
            {
                return savedJobs[UserId];
            }
            return new List<Job>();
        }


        public List<Job> GetJobs() 
        { return jobs; }

        public void PrintAllappliedJobs()
        {
            if (appliedJobs.Count == 0)
            {
                Console.WriteLine("No jobs have been applied by any user.");
                return;
            }
            Console.WriteLine("-----------All applied Jobs----------\n");
            foreach (var e in appliedJobs)
            {
                int UserId = e.Key;
                List<Job> jobs = e.Value;

                Console.WriteLine($"User id : {UserId}");
                if (jobs.Count == 0)
                {
                    Console.WriteLine("No Jobs have been applied");
                }
                else
                {

                    foreach (var job in jobs)
                    {
                        Console.WriteLine($"  Job ID: {job.Id}, Title: {job.Title}, Company: {job.Company}");
                    }
                }
                Console.WriteLine();


            }
        }

       
    }
}
