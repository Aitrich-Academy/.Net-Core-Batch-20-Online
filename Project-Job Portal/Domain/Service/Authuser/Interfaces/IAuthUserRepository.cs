<<<<<<< HEAD
﻿using System;
=======
﻿using Domain.Models;
using System;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Domain.Models;
=======
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserRepository
    {
<<<<<<< HEAD
        Task<AuthUser> AddAuthUserJP(AuthUser authUser);
        Task AddUserAsync(AuthUser authUser);
        string? CreateToken(AuthUser user);
    }
}
=======
        Task<AuthUser> AddAuthUserJS(AuthUser authUser);
        string? CreateToken(AuthUser user);

    }
}
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
