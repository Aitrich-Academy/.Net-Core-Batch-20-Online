using AdminPortal.Data;
using AdminPortal.Interface;
using AdminPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.Repository
{
    public class EmpRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmpRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> AddEmpAsync(Employee emp)
        {
            _context.employees.Add(emp);
            await _context.SaveChangesAsync();
            return emp ;
        }

        public async Task<IEnumerable<Employee>> GetEmpAsync()
        {
            return await _context.employees.ToListAsync();
        }

        public async Task<Employee> GetEmpByIdAsync(Guid id)
        {
            return await _context.employees.FindAsync(id);
        }

        public async Task<Employee> UpdateEmpAsync(Employee emp)
        {
            _context.employees.Update(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<bool> DeleteEmpAsync(Guid id)
        {
            var emp = await _context.employees.FindAsync(id);
            if (emp == null) return false;

            _context.employees.Remove(emp);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Employee> GetEmpByEmailAsync(string email)
        {
            return await _context.employees.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
