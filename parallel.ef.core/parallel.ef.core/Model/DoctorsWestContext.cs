using Microsoft.EntityFrameworkCore;

namespace parallel.ef.core.Model
{
    public class DoctorsWestContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        // Add other DbSet properties for your other entities here

        // Constructor to specify the connection string
        public DoctorsWestContext() : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    DoctorNumber = 1,
                    DoctorSurname = "Smith",
                    DoctorFirstname = "John",
                    DoctorMiddlename = "A",
                    DoctorPrefix = "Dr.",
                    DoctorDegree = "MD",
                    EmployClassif = "Full Time",
                    Dob = new DateTime(1970, 1, 1),
                    Gender = "M",
                    ContactNo = "1234567890",
                    ProviderNumber = "P123456",
                    DownloadStamp = DateTime.Now,
                    ThrAllocWeight = 1,
                    ThrYesPrefDay = "Monday",
                    ThrYesPrefSess = "Morning",
                    ThrNoPrefDay = "Sunday",
                    ThrNoPrefSess = "Evening",
                    Timestamp = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04 },
                    DoctorPhoneDay = "1234567890",
                    DoctorPhoneHome = "0987654321",
                    DoctorPhoneBusiness = "1122334455",
                    DoctorPhoneMobile = "5566778899",
                    DoctorPhonePager = "7788991122",
                    DoctorPhoneFax = "8899112233",
                    DoctorAddress = "123 Main St",
                    DoctorAddress2 = "Apt 4B",
                    DoctorSuburb = "Cityville",
                    DoctorPostCode = 12345,
                    DoctorEmail = "johnsmith@example.com",
                    DoctorProfStatus = "Active",
                    DoctorStartDate = new DateTime(2000, 1, 1),
                    DoctorEndDate = new DateTime(2030, 1, 1),
                    DoctorNrn = "NRN123"
                },
                new Doctor
                {
                    DoctorNumber = 2,
                    DoctorSurname = "Johnson",
                    DoctorFirstname = "Jane",
                    DoctorMiddlename = "B",
                    DoctorPrefix = "Dr.",
                    DoctorDegree = "MD",
                    EmployClassif = "Part Time",
                    Dob = new DateTime(1975, 2, 2),
                    Gender = "F",
                    ContactNo = "2345678901",
                    ProviderNumber = "P234567",
                    DownloadStamp = DateTime.Now,
                    ThrAllocWeight = 2,
                    ThrYesPrefDay = "Tuesday",
                    ThrYesPrefSess = "Afternoon",
                    ThrNoPrefDay = "Monday",
                    ThrNoPrefSess = "Morning",
                    Timestamp = new byte[] { 0x05, 0x06, 0x07, 0x08, 0x09 },
                    DoctorPhoneDay = "2345678901",
                    DoctorPhoneHome = "1098765432",
                    DoctorPhoneBusiness = "2233445566",
                    DoctorPhoneMobile = "6677889900",
                    DoctorPhonePager = "8899001122",
                    DoctorPhoneFax = "9900112233",
                    DoctorAddress = "234 Main St",
                    DoctorAddress2 = "Apt 5C",
                    DoctorSuburb = "Townville",
                    DoctorPostCode = 23456,
                    DoctorEmail = "janejohnson@example.com",
                    DoctorProfStatus = "Active",
                    DoctorStartDate = new DateTime(2005, 2, 2),
                    DoctorEndDate = new DateTime(2035, 2, 2),
                    DoctorNrn = "NRN234"
                }
            );
        }
    }
}