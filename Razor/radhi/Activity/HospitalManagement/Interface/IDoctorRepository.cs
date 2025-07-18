using HospitalManagement.Dto;
using HospitalManagement.Models;

namespace HospitalManagement.Interface
{
    public interface IDoctorRepository
    {
        public Task<List<Doctor>> GetAllAsync();

        public Task<Doctor> GetDoctorByIdAsync(int id);
        public Task AddDoctorAsync(Doctor doctor);


        public Task UpdateDoctorAsync(int id, Doctor doctorDto);

        public Task DeleteDoctorAsync(int id);


    }
}
