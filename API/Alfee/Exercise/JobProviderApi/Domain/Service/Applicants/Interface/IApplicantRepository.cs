using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Service.Applicants.Interface
{
    public interface IApplicantRepository
    {
        Task<List<Applicant>> GetApplicantsByJobProviderIdAsync(Guid jobProviderId);
    }
}
