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

        public static List<Application> Allappliedjobs = new List<Application>();

       

        int Jobid = 1;

        public void PostJob(Job job)
        {
            job.Id = Jobid;
            jobs.Add(job);
            Jobid++;
        }

        public void AddAppliedJob(Application job)
        {
          Allappliedjobs.Add(job);
        }

       
        public List<Job> GetJobs() 
        { return jobs; }

        public List<Application> GetApplied()
        {
            return Allappliedjobs;
        }



       
    }
}
