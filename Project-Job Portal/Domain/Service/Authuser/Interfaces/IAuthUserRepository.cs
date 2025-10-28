
﻿using System;
﻿using Domain.Models;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models;


namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserRepository
    {

        Task<AuthUser> AddAuthUserJP(AuthUser authUser);
        Task AddUserAsync(AuthUser authUser);
        string CreateToken(AuthUser user);


        Task<AuthUser> AddAuthUserJS(AuthUser authUser);
      

    }
}

       
    