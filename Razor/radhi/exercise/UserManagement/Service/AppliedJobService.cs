using System;
using UserManagement.Interface;
using UserManagement.Models;
using UserManagement.Repository;
using static UserManagement.Service.AppliedJobService;

namespace UserManagement.Service
{

    public class AppliedJobService : IAppliedService
    {
        private readonly IAppliedRepository _repository;

        public AppliedJobService(IAppliedRepository repository)
        {
            _repository = repository;
        }

        public async Task ApplyForJobAsync(int userId, int jobId)
        {
            await _repository.ApplyForJobAsync(userId, jobId);
        }

        public async Task<List<Job>> GetAppliedJobsByUserIdAsync(int userId)
        {
            return await _repository.GetAppliedJobsByUserIdAsync(userId);
        }

    }
}