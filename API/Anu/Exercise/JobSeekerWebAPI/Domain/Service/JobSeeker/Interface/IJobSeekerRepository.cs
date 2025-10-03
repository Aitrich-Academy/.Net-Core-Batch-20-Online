using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Job.DTO;
using Domain.Service.JobSeeker.DTO;

namespace Domain.Service.JobSeeker.Interface
{
    public interface    IJobSeekerRepository
    {
        Task<RegisterUser> ViewSeekerByIdAsync(Guid id);

        Task<RegisterUser> UpdateSeekerAsync(RegisterUser reguser);

        Task<List<ViewappliedDto>> GetAppliedJobsByUserAsync(Guid userId);
    }
}
