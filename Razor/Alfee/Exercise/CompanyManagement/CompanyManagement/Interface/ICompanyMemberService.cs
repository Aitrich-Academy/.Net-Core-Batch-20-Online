using CompanyManagement.Dto;

namespace CompanyManagement.Interface
{
    public interface ICompanyMemberService
    {
        Task<bool> AddMemberAsync(CompanyMemberDto dto, int userId);
        Task<List<CompanyMemberDto>> GetMembersByUserIdAsync(int userId);

        Task<CompanyMemberDto> GetMemberByIdAsync(int id);
        Task<bool> UpdateMemberAsync(CompanyMemberDto dto);

        Task<bool> DeleteMemberAsync(int id, int userId);
    }
}
