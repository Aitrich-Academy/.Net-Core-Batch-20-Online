using AutoMapper;
using JobPortalMVC.Dto;
using JobPortalMVC.Interface;
using JobPortalMVC.Models;
using JobPortalMVC.Repository;


namespace JobPortalMVC.Service
{
    public class JobService : IJobService
    {

        private readonly IJobRepository _repository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<JobDto> AddJob(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            var newJob = await _repository.AddJob(job);
            return _mapper.Map<JobDto>(newJob);
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _repository.GetAllJobsAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _repository.GetJobByIdAsync(id);
        }

        public async Task UpdateJobAsync(int id, JobDto dto)
        {
            var existing = await _repository.GetJobByIdAsync(id);
            if (existing == null)
                throw new InvalidOperationException($"Job with ID {id} not found.");

            _mapper.Map(dto, existing);
            await _repository.UpdateAndSaveAsync(existing);
        }

        public async Task DeleteJobAsync(int id)
        {
            await _repository.DeleteJobAsync(id);
        }
    }
}
