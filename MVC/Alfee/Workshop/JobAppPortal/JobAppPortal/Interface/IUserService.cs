using JobAppPortal.Models;

namespace JobAppPortal.Interface
{
    public interface IUserService
    {
        User GetBiId(Guid guid);
    }
}
