using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.JobProviders.Dto;

namespace Domain.Service.JobProviders.Interface
{
    public interface IUserService
    {
        Task<string?> RegisterAsync(JobProviderRegisterDto dto);
        Task<string?> LoginAsync(JobProviderLoginDto dto);
    }
}
