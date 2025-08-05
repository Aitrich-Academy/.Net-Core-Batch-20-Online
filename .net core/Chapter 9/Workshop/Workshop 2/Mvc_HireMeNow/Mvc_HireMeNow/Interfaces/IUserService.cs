using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
	public interface IUserService
	{
		
		User GetById(Guid guid);
	}
}
