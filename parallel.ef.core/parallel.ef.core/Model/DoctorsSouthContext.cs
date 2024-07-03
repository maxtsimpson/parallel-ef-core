using Microsoft.EntityFrameworkCore;

namespace parallel.ef.core.Model
{
    public class DoctorsSouthContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        // Add other DbSet properties for your other entities here

        // Constructor to specify the connection string
        public DoctorsSouthContext() : base()
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
                    DoctorNumber = 4,
                    DoctorSurname = "Robbins",
                    DoctorFirstname = "Baskin",
                    DoctorMiddlename = "",
                    DoctorPrefix = "Dr.",
                    DoctorDegree = "MD",
                    EmployClassif = "Part Time",
                    Dob = new DateTime(1982, 5, 5),
                    Gender = "M",
                    ContactNo = "4567890123",
                    ProviderNumber = "P456789",
                    DownloadStamp = DateTime.Now,
                    ThrAllocWeight = 4,
                    ThrYesPrefDay = "Thursday",
                    ThrYesPrefSess = "Afternoon",
                    ThrNoPrefDay = "Wednesday",
                    ThrNoPrefSess = "Morning",
                    Timestamp = new byte[] { 0x0F, 0x10, 0x11, 0x12, 0x13 },
                    DoctorPhoneDay = "4567890123",
                    DoctorPhoneHome = "3210987654",
                    DoctorPhoneBusiness = "4455667788",
                    DoctorPhoneMobile = "8899001122",
                    DoctorPhonePager = "1100223344",
                    DoctorPhoneFax = "2233445566",
                    DoctorAddress = "456 Main St",
                    DoctorAddress2 = "Apt 7E",
                    DoctorSuburb = "Boroughville",
                    DoctorPostCode = 45678,
                    DoctorEmail = "baskinrobbins@example.com",
                    DoctorProfStatus = "Active",
                    DoctorStartDate = new DateTime(2015, 5, 5),
                    DoctorEndDate = new DateTime(2045, 5, 5),
                    DoctorNrn = "NRN456"
                }
            );
        }
    }
}