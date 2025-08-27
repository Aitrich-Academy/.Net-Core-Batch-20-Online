using AutoMapper;
using HospitalPortal.Dtos;
using HospitalPortal.Interfaces;
using HospitalPortal.Models;

namespace HospitalPortal.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepo;
        private readonly IMapper _mapper;

        public DoctorService(IDoctorRepository doctorRepo, IMapper mapper)
        {
            _doctorRepo = doctorRepo;
            _mapper = mapper;
        }

        public void AddDoctor(DoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctor>(doctorDto);
            _doctorRepo.AddDoctor(doctor);
        }

        public DoctorDto? GetById(int id)
        {
            var doctor = _doctorRepo.GetById(id);
            return _mapper.Map<DoctorDto>(doctor);
        }

        public IEnumerable<DoctorDto> GetAll()
        {
            var doctors = _doctorRepo.GetAll();
            return _mapper.Map<IEnumerable<DoctorDto>>(doctors);
        }
    }
}
