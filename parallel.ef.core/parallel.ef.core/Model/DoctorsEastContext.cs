using Microsoft.EntityFrameworkCore;

namespace parallel.ef.core.Model
{
    public class DoctorsEastContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        // Add other DbSet properties for your other entities here

        // Constructor to specify the connection string
        public DoctorsEastContext() : base()
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
                    Timestamp = DateTime.Now,
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
                    DoctorNumber = 3,
                    DoctorSurname = "Vern",
                    DoctorFirstname = "Troy",
                    DoctorMiddlename = "",
                    DoctorPrefix = "Dr.",
                    DoctorDegree = "MD",
                    EmployClassif = "Full Time",
                    Dob = new DateTime(1985, 4, 4),
                    Gender = "M",
                    ContactNo = "3456789012",
                    ProviderNumber = "P345678",
                    DownloadStamp = DateTime.Now,
                    ThrAllocWeight = 3,
                    ThrYesPrefDay = "Wednesday",
                    ThrYesPrefSess = "Afternoon",
                    ThrNoPrefDay = "Tuesday",
                    ThrNoPrefSess = "Morning",
                    Timestamp = DateTime.Now,
                    DoctorPhoneDay = "3456789012",
                    DoctorPhoneHome = "2109876543",
                    DoctorPhoneBusiness = "3344556677",
                    DoctorPhoneMobile = "7788990011",
                    DoctorPhonePager = "9900112244",
                    DoctorPhoneFax = "1100223344",
                    DoctorAddress = "345 Main St",
                    DoctorAddress2 = "Apt 6D",
                    DoctorSuburb = "Villageville",
                    DoctorPostCode = 34567,
                    DoctorEmail = "troyvern@example.com",
                    DoctorProfStatus = "Active",
                    DoctorStartDate = new DateTime(2010, 4, 4),
                    DoctorEndDate = new DateTime(2040, 4, 4),
                    DoctorNrn = "NRN345"
                }

            );
        }
    }
}