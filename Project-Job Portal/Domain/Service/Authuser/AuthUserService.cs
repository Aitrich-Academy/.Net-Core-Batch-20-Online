using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Domain.Service.Authuser.Interfaces;
using Microsoft.AspNetCore.Http;
=======
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341

namespace Domain.Service.Authuser
{
    public class AuthUserService : IAuthUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAuthUserRepository _userRepository;
<<<<<<< HEAD

        public AuthUserService(IHttpContextAccessor httpContextAccessor, IAuthUserRepository userRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
=======
        private readonly HireMeNowDbContext _context;

        public AuthUserService(IHttpContextAccessor httpContextAccessor, IAuthUserRepository userRepository, HireMeNowDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _context = context;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
        }

        public string GetUserId()
        {
            var result = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value.ToString();
            }
            return result;
        }
<<<<<<< HEAD
=======

        public async Task LogoutAsync(Guid userId)
        {
            var user = await _context.AuthUsers.FindAsync(userId);
            if (user != null)
            {
                user.ConnectionId = null;
                user.OnlineStatus = false;
                await _context.SaveChangesAsync();
            }
        }

>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
    }
}
