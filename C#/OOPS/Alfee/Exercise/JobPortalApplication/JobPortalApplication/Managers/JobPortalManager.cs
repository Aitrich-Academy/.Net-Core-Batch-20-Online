using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;

namespace JobPortalApplication.Managers
{
    public class JobPortalManager: IUser, IJobProvider, IInterviewProvider
    {
        private List<User> users = new List<User>();
        private List<Job> jobs = new List<Job>();
        private List<Interview> interviews = new List<Interview>();

        public void Register(User user)
        {
            users.Add(user);
        }

        public bool Login(string username, string password)
        {
            return users.Any(u => u.Email == username && u.Password == password);
        }

        public void PostJob(Job job)
        {
            jobs.Add(job);
        }

        public Job[] GetJobs()
        {
            return jobs.ToArray();
        }

        public void ScheduleInterview(Interview interview)
        {
            interviews.Add(interview);
        }

        public Interview[] GetInterviews()
        {
            return interviews.ToArray();
        }

    }
}
