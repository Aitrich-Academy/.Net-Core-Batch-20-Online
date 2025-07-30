using CustomerFeedbackApp.Models;

namespace CustomerFeedbackApp.Interfaces
{
    public interface IFeedbackServices
    {
        Task AddFeedbackAsync(Feedback feedback);
        Task<List<Feedback>> GetAllFeedbacksAsync();
    }
}
