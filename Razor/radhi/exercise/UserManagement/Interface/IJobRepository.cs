using UserManagement.Dto;
using UserManagement.Models;

namespace UserManagement.Interface
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);


      
 
    
    }
}
