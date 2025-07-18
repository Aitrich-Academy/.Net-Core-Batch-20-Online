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
            var doctors = await _context.Doctors.ToListAsync();
            return doctors;
        }

        public async Task<Doctors> GetDoctorByIdAsync(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            return _mapper.Map<Doctors>(doctor);
        }

        public async Task AddDoctorAsync(DoctorDto doctorDto)
        {
            var doctor = _mapper.Map<Doctors>(doctorDto);
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDoctorAsync(int id, Doctors doctorDto)
        {
            var existingDoctor = await _context.Doctors.FindAsync(id);
            if (existingDoctor == null) return; // Ensure doctor exists

            _context.Entry(existingDoctor).State = EntityState.Detached; // Detach old instance

            var updatedDoctor = _mapper.Map<Doctors>(doctorDto);
            updatedDoctor.Id = id; // Ensure the ID remains the same

            _context.Doctors.Attach(updatedDoctor); // Attach the new instance
            _context.Entry(updatedDoctor).State = EntityState.Modified; // Mark as modified

            await _context.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var job = await _context.Doctors.FindAsync(id);
            if (job != null)
            {
                _context.Doctors.Remove(job);
                await _context.SaveChangesAsync();
            }
        }
    }
  
}
