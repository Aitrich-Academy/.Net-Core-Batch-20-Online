using JobSeekerPortal.Models;

namespace JobSeekerPortal.Interfaces
{
    public interface IJobRepository
    {
        Task<Job?> GetByIdAsync(int id);
        Task<IEnumerable<Job>> GetAllAsync();
        Task AddAsync(Job job);
        void Update(Job job);
        void Delete(Job job);
        Task SaveChangesAsync();
    }
}
