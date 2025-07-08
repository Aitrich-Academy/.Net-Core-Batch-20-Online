using HospitalManagement.Dto;
using HospitalManagement.Model;

namespace HospitalManagement.Interface
{
    public interface IDoctorRepository
    {
        public Task<List<Doctors>> GetAllDoctorsAsync();

        public Task<Doctors> GetDoctorByIdAsync(int id);


        public Task AddDoctorAsync(DoctorDto doctorDto);


        public Task UpdateDoctorAsync(int id, Doctors doctorDto);

        public Task DeleteDoctorAsync(int id);
    }
}
