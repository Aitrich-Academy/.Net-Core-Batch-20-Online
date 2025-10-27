<<<<<<< HEAD
﻿using System;
=======
﻿
using Domain.Models;
using System;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserService
    {
        string GetUserId();
<<<<<<< HEAD

    }

}
=======
        Task LogoutAsync(Guid userId);

    }
}
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
