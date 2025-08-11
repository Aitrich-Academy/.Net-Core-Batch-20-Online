using HireMeNowMVC.Models;

namespace HireMeNowMVC.Interface
{
    public interface  IPublicService
    {
        public User LoginJobProvider(string email, string password);
        public User Register(User newJobSeeker);
    }
}
