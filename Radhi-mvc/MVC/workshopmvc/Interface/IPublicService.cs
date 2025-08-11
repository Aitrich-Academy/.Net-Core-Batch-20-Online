using workshopmvc.Models;

namespace workshopmvc.Interface
{
    public interface IpublicService
    {
        public User LoginJobProvider(string email, string password);
        public User Register(User newJobSeeker);

    }
}
