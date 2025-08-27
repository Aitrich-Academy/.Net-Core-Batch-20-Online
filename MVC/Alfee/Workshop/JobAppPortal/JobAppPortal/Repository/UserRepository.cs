using JobAppPortal.Enum;
using JobAppPortal.Interface;
using JobAppPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace JobAppPortal.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly AppDbContext _context;

        private static User loggedUser = new User();

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User getById(Guid userid)
        {
            User user = _context.Users.Where(e => e.Id == userid)
                .IgnoreAutoIncludes().FirstOrDefault();

            return user;
        }

        public User login(string email, string password)
        {
            loggedUser = _context.Users.Where(e => e.Email == email && e.password == password).FirstOrDefault();
            return loggedUser;
        }

        public User getLoggedUser()
        {
            return loggedUser;
        }


        public User register(User user)
        {
            user.Role = Roles.JobProvider;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
