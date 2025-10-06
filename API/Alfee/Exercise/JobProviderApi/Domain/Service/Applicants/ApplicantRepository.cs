using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Service.Applicants.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Applicants
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly AppDbContext _context;

        public ApplicantRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Applicant>> GetApplicantsByJobProviderIdAsync(Guid jobProviderId)
        {
            return await _context.Applicants
                .Where(a => a.JobProviderId == jobProviderId)
                .ToListAsync();
        }
    }
}
