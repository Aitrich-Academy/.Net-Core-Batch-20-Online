using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Applicants.Dto;
using Domain.Service.Applicants.Interface;

namespace Domain.Service.Applicants
{
    public class ApplicantService : IApplicantService
    {
        private readonly IApplicantRepository _repository;
        private readonly IMapper _mapper;

        public ApplicantService(IApplicantRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ApplicantDto>> GetApplicantsAsync(Guid jobProviderId)
        {
            var applicants = await _repository.GetApplicantsByJobProviderIdAsync(jobProviderId);
            return _mapper.Map<List<ApplicantDto>>(applicants);
        }
    }
}
