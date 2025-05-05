using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Interface;
using JobProvider.Models;

namespace JobProvider.Repository
{
    internal class JobRepository : IJobProvider
    {
       public static int JobId = 4;
      public static List<Job> jobs = new List<Job>
       
{
    new Job(1, "Software Developer","Develop software solutions","India","Offline","50000 - 70000","TechCorp Solutions"),
    new Job(2, "Data Analyst","Analyse Data","NewYork","Offline","80000 - 90000","Data Tech"),
    new Job(3, "Project Manager","Manage Teams and customers","Los Angles","Remote","90000 - 110000","Logistics Solutions"),

};
    
        public void PostJob(Job job)
        {
            job.Id = JobId;
            jobs.Add(job);
            JobId++;
        }
        public  List<Job> GetJobs() 
        {
            return jobs; 
        }
        public  Job GetJobById(int jobid)
            {
            return jobs.FirstOrDefault(jid => jid.Id == jobid);
        }
    }
}
