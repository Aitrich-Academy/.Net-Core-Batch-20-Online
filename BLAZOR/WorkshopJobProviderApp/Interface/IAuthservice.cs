using WorkshopJobProviderApp.Dto;

namespace WorkshopJobProviderApp.Interface
{
    public interface IAuthservice
    {
        Task<bool> Register(JobProviderDto jobProviderDto, string password);
        Task<bool> Login(string email, string password);
        Task Logout();
    }
}
