using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Login.DTO;
 using Domain.Service.Login.Interfaces;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService  
    {
        ILoginRequestRepository loginRepository;
        
        IMapper mapper;

        public LoginRequestService(ILoginRequestRepository _jobSeekerRepository, IMapper _mapper)
        {
            loginRepository = _jobSeekerRepository;
            mapper = _mapper;
  
        }

        public UserLoginDto Adminlogin(string email, string password)
        {
            var user = loginRepository.GetUserByEmail(email);
            if (user == null)
            {
                return null;
            }
            else
            {
                if ((password == user.Password))
                {
                    var userReturn = mapper.Map<UserLoginDto>(user);
                    userReturn.Token = loginRepository.CreateToken(user);
                    return userReturn;
                }
                return null;
            }

        }
    }
}
