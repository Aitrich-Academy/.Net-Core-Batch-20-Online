using workshopmvc.Interface;
using workshopmvc.Models;

namespace workshopmvc.Services
{
    public class UserService:IUserService
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
