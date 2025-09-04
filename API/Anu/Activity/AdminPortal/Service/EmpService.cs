using AutoMapper;
using AdminPortal.Dto;
using AdminPortal.Interface;
using AdminPortal.Models;

namespace AdminPortal.Service
{
    public class EmpService : IEmployeeService 
    {
        private readonly IEmployeeRepository  _empRepository;
        private readonly IMapper _mapper;

        public EmpService(IEmployeeRepository empRepository, IMapper mapper)
        {
            _empRepository = empRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeDto> AddempAsync(EmployeeDto empDto)
        {
            var existingUser = await _empRepository.GetEmpByEmailAsync(empDto.Email);
            if (existingUser != null)
                throw new Exception("User with this email already exists.");

            var emp = _mapper.Map<Employee>(empDto);
            emp = await _empRepository.AddEmpAsync(emp);
            return _mapper.Map<EmployeeDto>(emp);
        }

        public async Task<IEnumerable<EmployeeDto>> GetempAsync()
        {
            var emps = await _empRepository.GetEmpAsync(); 
            return _mapper.Map<IEnumerable<EmployeeDto>>(emps);
        }

        public async Task<EmployeeDto> GetempByIdAsync(Guid id)
        {
            var emp = await _empRepository.GetEmpByIdAsync(id);
            return _mapper.Map<EmployeeDto>(emp);
        }

        public async Task<EmployeeDto> UpdateempAsync(Guid id, EmployeeDto empDto)
        {

            var emp = await _empRepository.GetEmpByIdAsync(id);
            if (emp == null) return null;

            _mapper.Map(empDto,emp);
            await _empRepository.UpdateEmpAsync(emp);
            return _mapper.Map<EmployeeDto>(emp);
        }

        public async Task<bool> DeleteempAsync(Guid id)
        {
            return await _empRepository.DeleteEmpAsync(id);
        }
    }
}
