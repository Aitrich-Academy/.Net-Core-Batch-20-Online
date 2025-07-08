using CompanyManagement.Model;

namespace CompanyManagement.Interface
{
    public interface ICompanyMemberRepository
    {
        Task<bool> AddMemberAsync(CompanyMember member);
        Task<List<CompanyMember>> GetMembersByUserIdAsync(int userId);

        Task<CompanyMember> GetByIdAsync(int id);
        Task<bool> UpdateAsync(CompanyMember member);

        Task<bool> DeleteAsync(CompanyMember member);
    }
}
