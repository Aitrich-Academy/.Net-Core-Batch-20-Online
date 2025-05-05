using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Model;

namespace Excercise.Interface
{
    public interface IJobInterface
    {
        public void postJob(Jobs jobs);
        public void listJobs();
        public void applyJobs(Jobs job ,User user);
        public Jobs findJob(int jobid);
        public void saveJobs(Jobs job, User user);

        public void showsavedJobs();

        public void showappliedJobs();
    }
}
