using System;

namespace parallel.ef.core.Model.Request
{
    public class AddDoctorRequest
    {
        public string Name { get; set; }
        public string DoctorNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Add any other properties you need for the request

        // You can also add validation logic here if needed
        public bool IsValid()
        {
            // Implement your validation logic here
            // For example, check if required properties are not null or empty
            return !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Specialization);
        }
    }
}