using BlazorApp3.Model;

namespace BlazorApp3.Interface
{
    public interface IEmpService
    {
        public Task<List<Employee>> GetEmployeesAsync();

        public Task<Employee> GetEmployeeByIdAsync(int id);

        public Task AddEmployeeAsync(Employee employee);

        public Task UpdateEmployeeAsync(Employee employee);

        public Task DeleteEmployeeAsync(int id);
    }
}
