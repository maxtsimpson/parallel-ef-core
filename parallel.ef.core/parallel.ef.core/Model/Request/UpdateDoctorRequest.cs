using System;

namespace parallel.ef.core.Model
{
    public class UpdateDoctorRequest
    {
        public Doctor doctor { get; set; }

        public EventData eventData { get; set; }
    }
    
}