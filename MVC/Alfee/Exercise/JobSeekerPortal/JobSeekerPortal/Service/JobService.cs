using AutoMapper;
using JobSeekerPortal.Dtos;
using JobSeekerPortal.Interfaces;
using JobSeekerPortal.Models;

namespace JobSeekerPortal.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepo;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepo, IMapper mapper)
        {
            _jobRepo = jobRepo;
            _mapper = mapper;
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            await _jobRepo.AddAsync(job);
            await _jobRepo.SaveChangesAsync();
        }

        public async Task<IEnumerable<JobDto>> GetAllAsync()
        {
            var jobs = await _jobRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        public async Task<JobDto?> GetByIdAsync(int id)
        {
            var job = await _jobRepo.GetByIdAsync(id);
            return _mapper.Map<JobDto?>(job);
        }

        public async Task UpdateJobAsync(JobDto jobDto)
        {
            var job = await _jobRepo.GetByIdAsync(jobDto.Id);
            if (job != null)
            {
                _mapper.Map(jobDto, job);
                _jobRepo.Update(job);
                await _jobRepo.SaveChangesAsync();
            }
        }
    }
}
