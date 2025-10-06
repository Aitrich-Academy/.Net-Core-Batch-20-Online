using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Model;
using Domain.Service.Interviews.Dto;
using Domain.Service.Interviews.Interface;

namespace Domain.Service.Interviews
{
    public class InterviewService : IInterviewService
    {
        private readonly IInterviewRepository _repository;
        private readonly IMapper _mapper;

        public InterviewService(IInterviewRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<InterviewDto>> GetInterviewsAsync(Guid jobProviderId)
        {
            var interviews = await _repository.GetInterviewsAsync(jobProviderId);
            return _mapper.Map<List<InterviewDto>>(interviews);
        }

        public async Task<InterviewDto> ScheduleInterviewAsync(InterviewDto dto)
        {
            var interview = _mapper.Map<Interview>(dto);
            var result = await _repository.ScheduleInterviewAsync(interview);
            return _mapper.Map<InterviewDto>(result);
        }

        public async Task<InterviewDto?> UpdateInterviewAsync(InterviewDto dto)
        {
            var interview = _mapper.Map<Interview>(dto);
            var result = await _repository.UpdateInterviewAsync(interview);
            return result == null ? null : _mapper.Map<InterviewDto>(result);
        }

        public async Task<bool> DeleteInterviewAsync(Guid id)
        {
            return await _repository.DeleteInterviewAsync(id);
        }
    }
}
