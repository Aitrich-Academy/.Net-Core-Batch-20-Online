//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Domain.Models;
//using Domain.Service.Login.Interfaces;
//using Microsoft.EntityFrameworkCore;


//namespace Domain.Service.Login
//{
//    public class LoginRequestRepository : ILoginRequestRepository
//    {
//        private readonly HireMeNowDbContext _context;
//        public LoginRequestRepository(HireMeNowDbContext context)
//        {
//            _context = context;

//        }

//        public AuthUser? GetUserByEmail(string email)
//        {
//            try
//            {
//                return _context.AuthUsers
//                    .FirstOrDefault(u => u.Email == email);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception($"Error fetching user by email: {ex.Message}");
//            }
//        }


//    }
//}
