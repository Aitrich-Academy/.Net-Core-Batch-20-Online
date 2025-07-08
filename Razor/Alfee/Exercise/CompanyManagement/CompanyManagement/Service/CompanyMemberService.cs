using AutoMapper;
using CompanyManagement.Dto;
using CompanyManagement.Interface;
using CompanyManagement.Model;

namespace CompanyManagement.Service
{
    public class CompanyMemberService:ICompanyMemberService
    {
        private readonly ICompanyMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public CompanyMemberService(ICompanyMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddMemberAsync(CompanyMemberDto dto, int userId)
        {
            var member = _mapper.Map<CompanyMember>(dto);
            member.UserId = userId;

            return await _memberRepository.AddMemberAsync(member);
        }

        public async Task<List<CompanyMemberDto>> GetMembersByUserIdAsync(int userId)
        {
            var members = await _memberRepository.GetMembersByUserIdAsync(userId);
            return _mapper.Map<List<CompanyMemberDto>>(members);
        }

        public async Task<CompanyMemberDto> GetMemberByIdAsync(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            return _mapper.Map<CompanyMemberDto>(member);
        }

        public async Task<bool> UpdateMemberAsync(CompanyMemberDto dto)
        {
            var entity = _mapper.Map<CompanyMember>(dto);
            return await _memberRepository.UpdateAsync(entity);
        }

        public async Task<bool> DeleteMemberAsync(int id, int userId)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            if (member == null || member.UserId != userId)
                return false;

            return await _memberRepository.DeleteAsync(member);
        }
    }
}

