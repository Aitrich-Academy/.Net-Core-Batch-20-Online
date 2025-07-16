using AutoMapper;
using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Interface;
using JobPortal.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repository
{
    public class AppliedRepository : IAppliedRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AppliedRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        // public async Task ApplyToJobAsync(int userId, int jobId)
        // {
        //     bool exists = await _context.AppliedJobs
        //.AnyAsync(a => a.UserId == userId && a.JobId == jobId);

        //     if (!exists)
        //     {
        //         _context.AppliedJobs.Add(new Applied
        //         {
        //             UserId = userId,
        //             JobId = jobId,
        //             AppliedDate = DateTime.UtcNow  // set timestamp here
        //         });
        //         await _context.SaveChangesAsync();
        //     }
        // }
         

    }
}
