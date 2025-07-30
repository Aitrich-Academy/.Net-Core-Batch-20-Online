using CustomerFeedbackApp.Models;

namespace CustomerFeedbackApp.Interfaces
{
    public interface IFeedbackRepository
    {
        Task AddFeedbackAsync(Feedback feedback);
        Task<List<Feedback>> GetAllFeedbacksAsync();
    }
}
