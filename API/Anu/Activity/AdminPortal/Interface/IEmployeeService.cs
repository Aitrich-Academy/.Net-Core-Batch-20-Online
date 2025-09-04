using AdminPortal.Dto;
using AdminPortal.Models;

namespace AdminPortal.Interface
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> AddempAsync(EmployeeDto empDto);

        Task<IEnumerable<EmployeeDto>> GetempAsync();

        Task<EmployeeDto> GetempByIdAsync(Guid id);

        Task<EmployeeDto> UpdateempAsync(Guid id, EmployeeDto empDto);

        Task<bool> DeleteempAsync(Guid id);
    }
}
