using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parallel.ef.core.Model
{
    public class Doctor
    {
        public int DoctorNumber { get; set; }
        public string DoctorSurname { get; set; }
        public string DoctorFirstname { get; set; }
        public string DoctorMiddlename { get; set; }
        public string DoctorPrefix { get; set; }
        public string DoctorDegree { get; set; }
        public string EmployClassif { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string ProviderNumber { get; set; }
        public DateTime? DownloadStamp { get; set; }
        public short ThrAllocWeight { get; set; }
        public string ThrYesPrefDay { get; set; }
        public string ThrYesPrefSess { get; set; }
        public string ThrNoPrefDay { get; set; }
        public string ThrNoPrefSess { get; set; }
        public byte[] Timestamp { get; set; }
        public string DoctorPhoneDay { get; set; }
        public string DoctorPhoneHome { get; set; }
        public string DoctorPhoneBusiness { get; set; }
        public string DoctorPhoneMobile { get; set; }
        public string DoctorPhonePager { get; set; }
        public string DoctorPhoneFax { get; set; }
        public string DoctorAddress { get; set; }
        public string DoctorAddress2 { get; set; }
        public string DoctorSuburb { get; set; }
        public int? DoctorPostCode { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorProfStatus { get; set; }
        public DateTime? DoctorStartDate { get; set; }
        public DateTime? DoctorEndDate { get; set; }
        public string DoctorNrn { get; set; }
    }
}
