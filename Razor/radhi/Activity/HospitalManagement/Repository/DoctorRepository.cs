using AutoMapper;
using HospitalManagement.Dto;
using HospitalManagement.Interface;
using HospitalManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repository
{
    public class DoctorRepository:IDoctorRepository
    {
        private readonly HospitalDbContext _context;
        private readonly IMapper _mapper;

        public DoctorRepository(HospitalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<List<Doctor>> GetAllAsync()
        {
            var doct= await _context.Doctors.ToListAsync();
            return doct;
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            var doc = await _context.Doctors.FindAsync(id);
            return _mapper.Map<Doctor>(doc);
        }

        public async Task AddDoctorAsync(Doctor doctor)
        {
            var Doctor = _mapper.Map<Doctor>(doctor);
            _context.Doctors.Add(Doctor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDoctorAsync(int id, Doctor doctorDto)
        {
            var existingDoctor = await _context.Doctors.FindAsync(id);
            if (existingDoctor == null) return; // Ensure job exists

            _context.Entry(existingDoctor).State = EntityState.Detached; // Detach old instance

            var updatedDoctor = _mapper.Map<Doctor>(doctorDto);
            updatedDoctor.Id = id; // Ensure the ID remains the same

            _context.Doctors.Attach(updatedDoctor); // Attach the new instance
            _context.Entry(updatedDoctor).State = EntityState.Modified; // Mark as modified

            await _context.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
        }

       
    }

}

