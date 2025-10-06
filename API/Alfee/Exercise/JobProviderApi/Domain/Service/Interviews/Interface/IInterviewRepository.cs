using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Service.Interviews.Interface
{
    public interface IInterviewRepository
    {
        Task<List<Interview>> GetInterviewsAsync(Guid jobProviderId);
        Task<Interview> ScheduleInterviewAsync(Interview interview);
        Task<Interview?> UpdateInterviewAsync(Interview interview);
        Task<bool> DeleteInterviewAsync(Guid id);
    }
}
