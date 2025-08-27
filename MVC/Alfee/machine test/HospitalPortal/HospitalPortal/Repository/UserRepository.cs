using HospitalPortal.Interfaces;
using HospitalPortal.Models;

namespace HospitalPortal.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User? GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public User? GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
