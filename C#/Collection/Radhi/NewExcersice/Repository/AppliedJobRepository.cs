using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Model;

namespace NewExcersice.Repository
{
    public class AppliedJobRepository
    {
        private readonly List<AppliedJob> appliedJobs = new();
        public void ApplyJob(int UserId,int jobId)
        {
            appliedJobs.Add(new AppliedJob { UserId = UserId, JobId = jobId });
        }
        public List<AppliedJob>GetAppliedJobs(int userId)
        {
            return appliedJobs.FindAll(a => a.UserId
            == userId);
        }
        public class SavedJobRepository
        {
            private readonly List<SavedJob> _savedJobs = new();

            public void SaveJob(int userId, int jobId)
            {
                _savedJobs.Add(new SavedJob { UserId = userId, JobId = jobId });
            }

            public List<SavedJob> GetSavedJobs(int userId)
            {
                return _savedJobs.FindAll(s => s.UserId == userId);
            }
        }
    }
}
