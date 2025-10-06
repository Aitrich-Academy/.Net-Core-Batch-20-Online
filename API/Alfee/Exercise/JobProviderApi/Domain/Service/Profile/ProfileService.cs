using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Model;
using Domain.Service.Profile.Dto;
using Domain.Service.Profile.Interface;

namespace Domain.Service.Profile
{
    public class ProfileService : IProfileService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProfileService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<JobProviderProfileDto?> GetProfileAsync(Guid userId)
        {
            var user = await _context.JobProviders.FindAsync(userId);
            if (user == null) return null;

            return _mapper.Map<JobProviderProfileDto>(user);
        }

        public async Task<JobProviderProfileDto?> UpdateProfileAsync(JobProviderProfileDto dto)
        {
            var user = await _context.JobProviders.FindAsync(dto.Id);
            if (user == null) return null;

            user.Username = dto.Username;
            user.CompanyName = dto.CompanyName;

            await _context.SaveChangesAsync();
            return _mapper.Map<JobProviderProfileDto>(user);
        }
    }
}
