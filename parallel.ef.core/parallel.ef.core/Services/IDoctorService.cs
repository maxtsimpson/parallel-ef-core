using System.Collections.Generic;
using parallel.ef.core.Model;

namespace parallel.ef.core.Services
{
    public interface IDoctorService
    {
        Task<Doctor> GetDoctorById(int id, FacilityCode facilityCode);
        Task<IEnumerable<Doctor>> GetAllDoctors(FacilityCode facilityCode);
        Task AddDoctor(Doctor doctor, FacilityCode facilityCode);
        Task UpdateDoctor(Doctor doctor);
        Task DeleteDoctor(int id, FacilityCode facilityCode);
    }
}