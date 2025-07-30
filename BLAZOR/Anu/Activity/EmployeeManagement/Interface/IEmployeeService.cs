using EmployeeManagement.Models;

namespace EmployeeManagement.Interface
{
    public interface  IEmployeeService
    {
        public Task AddEmployeeAsync(Employee employee);
        public Task<List<Employee>> GetEmployeesAsync();

        public Task<Employee> GetEmployeeByIdAsync(int id);

        public Task UpdateEmployeeAsync(Employee employee);

        public Task DeleteEmployeeAsync(int id);
    }
}

