using HospitalManagement.Dto;
using HospitalManagement.Model;
using HospitalManagement.Repository;

namespace HospitalManagement.Interface
{
    public interface  IDoctorService 
    {
         
       public Task<List<Doctors>> GetAllDoctorsAsync();

        public Task<Doctors> GetDoctorByIdAsync(int id);


        public Task AddDoctorAsync(DoctorDto doctorDto);

        public Task UpdateDoctorsAsync(int id, Doctors doctorDto);

        public Task DeleteDoctorAsync(int id);
    }
}
