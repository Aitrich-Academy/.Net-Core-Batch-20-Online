using System;
using Microsoft.EntityFrameworkCore;
using workshopmvc.Enum;
using workshopmvc.Interface;
using workshopmvc.Models;

namespace workshopmvc.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private static User loggedUser = new User();


        public UserRepository (ApplicationDbContext context)
        {
            _context = context;
        }
        public User getById(Guid userid)
        {
            User user = _context.Users.Where(e => e.Id == userid).FirstOrDefault();

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
