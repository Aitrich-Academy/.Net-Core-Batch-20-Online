using HospitalManagement.Dto;
using HospitalManagement.Interface;
using HospitalManagement.Model;
using HospitalManagement.Repository;

namespace HospitalManagement.Services
{
    public class DoctorServices:IDoctorServices
    {
        private readonly DoctorRepository doctorRepository;
        public DoctorServices(DoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        public async Task<List<Doctors>> GetAllDoctorsAsync()
        {
            return await doctorRepository.GetAllDoctorsAsync();
        }

        public async Task<Doctors> GetDoctorsByIdAsync(int id)
        {
            return await doctorRepository.GetDoctorByIdAsync(id);
        }

        public async Task AddDoctorAsync(DoctorDto doctorDto)
        {
            await doctorRepository.AddDoctorAsync(doctorDto);
        }

        public async Task UpdateDoctorAsync(int id, Doctors doctorDto)
        {
            await doctorRepository.UpdateDoctorAsync(id, doctorDto);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await doctorRepository.DeleteDoctorAsync(id);
        }
    }
}
