using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Service.Interviews.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Interviews
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly AppDbContext _context;

        public InterviewRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Interview>> GetInterviewsAsync(Guid jobProviderId)
        {
            return await _context.Interviews
                .Where(i => i.JobProviderId == jobProviderId)
                .ToListAsync();
        }

        public async Task<Interview> ScheduleInterviewAsync(Interview interview)
        {
            _context.Interviews.Add(interview);
            await _context.SaveChangesAsync();
            return interview;
        }

        public async Task<Interview?> UpdateInterviewAsync(Interview interview)
        {
            var existing = await _context.Interviews.FindAsync(interview.Id);
            if (existing == null) return null;

            existing.ScheduledDate = interview.ScheduledDate;
            existing.Mode = interview.Mode;
            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteInterviewAsync(Guid id)
        {
            var interview = await _context.Interviews.FindAsync(id);
            if (interview == null) return false;

            _context.Interviews.Remove(interview);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
