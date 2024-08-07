namespace parallel.ef.core.Model.Events
{
    public class AddDoctorEvent : IEventData
    {
        public AddDoctorEvent(string messageID, FacilityCode facilityCode, Doctor doctor)
        {
            MessageID = messageID;
            FacilityCode = facilityCode;
            this.doctor = doctor;
        }

        public string MessageID { get; set; }

        public FacilityCode FacilityCode { get; set; }

        public Doctor doctor { get; }

        public EventType EventType { get; } = EventType.AddDoctor;
    }
}
