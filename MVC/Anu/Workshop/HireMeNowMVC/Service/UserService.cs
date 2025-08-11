using HireMeNowMVC.Interface;
using HireMeNowMVC.Models;


namespace HireMeNowMVC.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User GetBiId(Guid guid)
        {
            return repository.getById(guid);
        }
    }
}
