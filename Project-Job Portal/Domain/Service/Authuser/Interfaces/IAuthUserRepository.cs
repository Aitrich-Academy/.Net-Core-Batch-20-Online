
using Domain.Models;

public interface IAuthUserRepository
{
    string? CreateToken(AuthUser user);
}
