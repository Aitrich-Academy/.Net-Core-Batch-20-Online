using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;

namespace JobPortalApplication.Managers
{
    public class JobPortalManager : IUser, IJobProvider, IInterviewProvider
    {
      
        private List<User> users = new List<User>();
        private List<Job> jobs = new List<Job>();
        private List<Interview> interviews = new List<Interview>();
        private List<Application> applications = new List<Application>();

        public void Register(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public User Login(string email, string password)
        {
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public void PostJob(Job job)
        {
            job.Id = jobs.Count + 1;
            jobs.Add(job);
        }

        public Job[] GetJobs()
        {
            return jobs.ToArray();
        }

        public void ScheduleInterview(Interview interview)
        {
            interview.Id = interviews.Count + 1;
            interviews.Add(interview);
        }

        public Interview[] GetInterviews()
        {
            return interviews.ToArray();
        }

        public void ApplyToJob(string candidateEmail, int jobId)
        {
            applications.Add(new Application { CandidateEmail = candidateEmail, JobId = jobId });
        }

        public Application[] GetApplications(string email)
        {
            return applications.Where(a => a.CandidateEmail == email).ToArray();
        }
    }
}


 

 
 

     


 

 
