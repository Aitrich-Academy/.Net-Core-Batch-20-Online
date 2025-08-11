using HireMeNowMVC.Models;

namespace HireMeNowMVC.Interface
{
    public interface IUserService
    {

        User GetBiId(Guid guid);
    }
}
