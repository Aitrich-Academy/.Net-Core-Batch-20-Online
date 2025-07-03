using AutoMapper;
using HospitalManagement.Dto;
using HospitalManagement.Interface;
using HospitalManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repository
{
    public class DoctorRepository : IDoctorRepository 
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DoctorRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Doctors>> GetAllDoctorsAsync()
        {
            var mydoct = await _context.doctors.ToListAsync();
            return mydoct;

        }

        public async Task<Doctors> GetDoctorByIdAsync(int id)
        {
            var mydoct = await _context.doctors.FindAsync(id);
            return _mapper.Map<Doctors>(mydoct);
        }

        public async Task AddDoctorAsync(DoctorDto doctorDto)
        {
            var mydoct = _mapper.Map<Doctors>(doctorDto);
            _context.doctors.Add(mydoct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDoctorsAsync(int id, Doctors doctorDto)
        {
            var existingdoct = await _context.doctors.FindAsync(id);
            if (existingdoct == null) return; // Ensure job exists

            _context.Entry(existingdoct).State = EntityState.Detached; // Detach old instance

            var updateddoct = _mapper.Map<Doctors>(doctorDto);
            updateddoct.Id = id; // Ensure the ID remains the same

            _context.doctors.Attach(updateddoct); // Attach the new instance
            _context.Entry(updateddoct).State = EntityState.Modified; // Mark as modified

            await _context.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var mydoct = await _context.doctors.FindAsync(id);
            if (mydoct != null)
            {
                _context.doctors.Remove(mydoct);
                await _context.SaveChangesAsync();
            }
        }
    }
}
