using AutoMapper;
using JobApp.Dto;
using JobApp.Interface;
using JobApp.Model;

namespace JobApp.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobDto>> GetJobsAsync()
        {
            var jobs = await _jobRepository.GetJobsAsync();
            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        public async Task<JobDto> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<JobDto>(job);
        }

        public async Task<JobDto> AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            job = await _jobRepository.AddJobAsync(job);
            return _mapper.Map<JobDto>(job);
        }

        public async Task<JobDto> UpdateJobAsync(int id, JobDto jobDto)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            if (job == null) return null;

            _mapper.Map(jobDto, job);
            await _jobRepository.UpdateJobAsync(job);
            return _mapper.Map<JobDto>(job);
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            return await _jobRepository.DeleteJobAsync(id);
        }
    }
}
