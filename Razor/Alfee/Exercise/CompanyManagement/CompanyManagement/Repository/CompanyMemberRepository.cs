using CompanyManagement.Interface;
using CompanyManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Repository
{
    public class CompanyMemberRepository : ICompanyMemberRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyMemberRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddMemberAsync(CompanyMember member)
        {
            _context.CompanyMembers.Add(member);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<CompanyMember>> GetMembersByUserIdAsync(int userId)
        {
            return await _context.CompanyMembers
                                 .Where(m => m.UserId == userId)
                                 .ToListAsync();
        }

        public async Task<CompanyMember> GetByIdAsync(int id)
        {
            return await _context.CompanyMembers.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(CompanyMember member)
        {
            _context.CompanyMembers.Update(member);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(CompanyMember member)
        {
            _context.CompanyMembers.Remove(member);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

