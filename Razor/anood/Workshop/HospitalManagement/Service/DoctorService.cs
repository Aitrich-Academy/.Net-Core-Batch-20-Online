using AutoMapper;
using HospitalManagement.Dto;
using HospitalManagement.Interface;
using HospitalManagement.Model;
using HospitalManagement.Repository;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Service
{
    public class DoctorService : IDoctorService
    {
        private readonly DoctorRepository  doctorRepository;
        public DoctorService(DoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        public async Task<List<Doctors>> GetAllDoctorsAsync()
        {
            return await doctorRepository.GetAllDoctorsAsync();
        }

        public async Task<Doctors> GetDoctorByIdAsync(int id)
        {
            return await doctorRepository.GetDoctorByIdAsync(id);
        }


        public async Task AddDoctorAsync(DoctorDto doctorobDto)
        {
            await doctorRepository.AddDoctorAsync(doctorobDto);
        }

        public async Task UpdateDoctorsAsync(int id, Doctors mydoct)
        {
            await doctorRepository.UpdateDoctorsAsync(id, mydoct);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await doctorRepository.DeleteDoctorAsync(id);
        }
    }
}
