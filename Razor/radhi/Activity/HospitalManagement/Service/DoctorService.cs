using HospitalManagement.Dto;
using HospitalManagement.Models;
using HospitalManagement.Repository;
using HospitalManagement.Interface;

namespace HospitalManagement.Service
{
    public class DoctorService:IDoctorService
    {
        private readonly DoctorRepository doctorRepository;

        public DoctorService(DoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await doctorRepository.GetAllAsync();
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            return await doctorRepository.GetDoctorByIdAsync(id);
        }

        public async Task AddDoctorAsync(Doctor doctor)
        {
            await doctorRepository.AddDoctorAsync(doctor);
        }

        public async Task UpdateDoctorAsync(int id, Doctor doctorDto)
        {
            await doctorRepository.UpdateDoctorAsync(id,doctorDto );
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await doctorRepository.DeleteDoctorAsync(id);
        }

       
    }
}

