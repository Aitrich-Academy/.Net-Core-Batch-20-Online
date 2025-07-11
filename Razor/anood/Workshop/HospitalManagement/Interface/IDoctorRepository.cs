using AutoMapper;
using HospitalManagement.Dto;
using HospitalManagement.Interface;
using HospitalManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Interface
{
    public interface IDoctorRepository
    {
        public Task<List<Doctors>> GetAllDoctorsAsync();

        public Task<Doctors> GetDoctorByIdAsync(int id);


        public Task AddDoctorAsync(DoctorDto doctorDto);

        public Task UpdateDoctorsAsync(int id, Doctors doctorDto);

        public Task DeleteDoctorAsync(int id);
    }
}
