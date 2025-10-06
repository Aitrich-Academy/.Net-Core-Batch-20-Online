using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Interviews.Dto;

namespace Domain.Service.Interviews.Interface
{
    public interface IInterviewService
    {
        Task<List<InterviewDto>> GetInterviewsAsync(Guid jobProviderId);
        Task<InterviewDto> ScheduleInterviewAsync(InterviewDto dto);
        Task<InterviewDto?> UpdateInterviewAsync(InterviewDto dto);
        Task<bool> DeleteInterviewAsync(Guid id);
    }
}
