using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Job.DTO;
using Domain.Service.JobSeeker.DTO;
using Domain.Service.User.DTO;

namespace Domain.Service.JobSeeker.Interface
{
    public interface  IJobseekerService
    {
        Task<RegisterUserDto> ViewSeekerByIdAsync(Guid id);
        Task<SeekerDto> UpdateSeekerAsync(SeekerDto Jseekerdto);

        Task<List<ViewappliedDto>> GetAppliedJobsByUserAsync(Guid userId);
    }
}

