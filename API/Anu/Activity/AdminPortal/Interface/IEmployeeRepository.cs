using AdminPortal.Models;

namespace AdminPortal.Interface
{
    public interface  IEmployeeRepository
    {
        Task<Employee> AddEmpAsync(Employee employee);

        Task<IEnumerable<Employee>> GetEmpAsync();

        Task<Employee> GetEmpByIdAsync(Guid id);

        Task<Employee> UpdateEmpAsync(Employee employee);

        Task<bool> DeleteEmpAsync(Guid id);

        Task<Employee> GetEmpByEmailAsync(string email);
    }
}
