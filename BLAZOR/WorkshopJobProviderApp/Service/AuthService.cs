using AutoMapper;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using WorkshopJobProviderApp.Dto;
using WorkshopJobProviderApp.Interface;
using WorkshopJobProviderApp.Model;

namespace WorkshopJobProviderApp.Service
{
    public class AuthService:IAuthservice
    {
        private readonly IJobProviderRepository _jobProviderRepo;

        private readonly ProtectedSessionStorage _sessionStorage;
        private readonly IMapper _mapper;
        public AuthService(IJobProviderRepository jobProviderRepo, ProtectedSessionStorage sessionStorage, IMapper mapper)
        {
            _jobProviderRepo = jobProviderRepo;

            _sessionStorage = sessionStorage;
            _mapper = mapper;
        }
        public async Task<bool> Register(JobProviderDto jobProviderDto, string password)
        {
            var existingProvider = await _jobProviderRepo.GetByEmailAsync(jobProviderDto.Email);
            if (existingProvider != null)
                return false; // Email already exists

            var jobProvider = _mapper.Map<JobProvider>(jobProviderDto);
            jobProvider.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password); // Hash password

            await _jobProviderRepo.AddAsync(jobProvider);
            return true;

        }
        public async Task<bool> Login(string email, string password)
        {
            var jobProvider = await _jobProviderRepo.GetByEmailAsync(email);
            if (jobProvider == null || !BCrypt.Net.BCrypt.Verify(password, jobProvider.PasswordHash))
                return false;

            try
            {
                await _sessionStorage.SetAsync("JobProviderId", jobProvider.Id);
                await _sessionStorage.SetAsync("JobProviderEmail", jobProvider.Email);
                Console.WriteLine("Session stored successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Session error: " + ex.ToString());
            }

            return true;
        }

        public async Task Logout()
        {
            await _sessionStorage.DeleteAsync("JobProviderId");
            await _sessionStorage.DeleteAsync("JobProviderEmail");
        }
    }
}
