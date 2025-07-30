using CustomerFeedbackApp.Models;
using CustomerFeedbackApp.Data;
using CustomerFeedbackApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerFeedbackApp.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _context;

        public FeedbackRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddFeedbackAsync(Feedback feedback)
        {
            try
            {
                _context.Feedbacks.Add(feedback);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving feedback: " + ex.Message);
            }
        }

        public async Task<List<Feedback>> GetAllFeedbacksAsync()
        {
            return await _context.Feedbacks.ToListAsync();
        }
    }
}