using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Applicants.Dto;

namespace Domain.Service.Applicants.Interface
{
    public interface IApplicantService
    {
        Task<List<ApplicantDto>> GetApplicantsAsync(Guid jobProviderId);
    }
}
