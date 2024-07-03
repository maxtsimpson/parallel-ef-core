using parallel.ef.core.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace parallel.ef.core.Services
{
    public class DoctorService : IDoctorService
    {
        public Task<Doctor> GetDoctorById(int id, FacilityCode facilityCode)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Doctor>> GetAllDoctors(FacilityCode facilityCode)
        {
            throw new NotImplementedException();
        }

        public Task<void> AddDoctor(Doctor doctor, FacilityCode facilityCode)
        {
            throw new NotImplementedException();
        }

        public Task<void> UpdateDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Task<void> DeleteDoctor(int id, FacilityCode facilityCode)
        {
            throw new NotImplementedException();
        }
    }
}