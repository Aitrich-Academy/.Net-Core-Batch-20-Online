using AutoMapper;
using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Interface;
using JobPortal.Model;
using JobPortal.Repository;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Service
{
    public class AppliedService : IAppliedService
    {
        private readonly AppliedRepository appliedRepository;

        public AppliedService(AppliedRepository _appliedRepository)
        {
            appliedRepository = _appliedRepository;
        }
        
        //public async Task ApplyToJobAsync(int userId, int jobId)
        //{
        //    await appliedRepository.ApplyToJobAsync(userId, jobId);
        //}
    }
}
