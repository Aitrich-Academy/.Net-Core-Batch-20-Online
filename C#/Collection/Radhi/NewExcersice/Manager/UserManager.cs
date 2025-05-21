using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Exceptions;
using NewExcersice.Interfaces;
using NewExcersice.Model;
using NewExcersice.Repository;

namespace NewExcersice.Manager
{
    public class UserManager
    {
        private readonly UserRepository _repo;

        public UserManager(UserRepository repo)
        {
            _repo = repo;
        }

        public void Register(User user)
        {
            if (_repo.GetAllUsers().Any(u => u.Email == user.Email))
                throw new UserAlreadyExistsException("User already exists with this email.");

            _repo.Register(user);
        }

        public User Login(string email, string password)
        {
            var user = _repo.Login(email, password);
            if (user == null)
                throw new UserNotFoundException("Invalid email or password.");

            return user;
        }
    }
}