using System.Collections.Generic;

namespace parallel.ef.core.Services
{
    public interface IDoctorService
    {
        Task<Doctor> GetDoctorById(int id, FacilityCode facilityCode);
        Task<IEnumerable<Doctor>> GetAllDoctors(FacilityCode facilityCode);
        Task<void> AddDoctor(Doctor doctor, FacilityCode facilityCode);
        Task<void> UpdateDoctor(Doctor doctor);
        Task<void> DeleteDoctor(int id, FacilityCode facilityCode);
    }
}