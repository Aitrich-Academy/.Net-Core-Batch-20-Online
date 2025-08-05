using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
	public interface IUserRepository
	{
		
		User getLoggedUser();
	
		User login(string email, string password);
		User register(User user);
		User getById(Guid uid);

	}
}
