using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Service.JobProviders.Interface
{
    public interface IUserRepository
    {
        Task<JobProvider?> GetByEmailAsync(string email);
        Task RegisterAsync(JobProvider user);
    }
}
