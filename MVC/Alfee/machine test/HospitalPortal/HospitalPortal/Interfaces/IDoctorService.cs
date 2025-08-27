using HospitalPortal.Dtos;

namespace HospitalPortal.Interfaces
{
    public interface IDoctorService
    {
        void AddDoctor(DoctorDto doctorDto);
        DoctorDto? GetById(int id);
        IEnumerable<DoctorDto> GetAll();
    }
}
