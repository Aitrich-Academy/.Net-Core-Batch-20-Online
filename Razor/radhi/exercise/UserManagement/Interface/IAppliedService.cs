using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Interface
{
    public interface IAppliedService
    {
        Task ApplyForJobAsync(int userId, int jobId);
        Task<List<Job>> GetAppliedJobsByUserIdAsync(int userId);
       

    }
}
