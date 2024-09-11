namespace parallel.ef.core.Model.Events
{
    public class AddDoctorEvent : EventData
    {
        public AddDoctorEvent(string messageID, FacilityCode facilityCode, Doctor doctor)
        {
            this.MessageID = messageID;
            this.FacilityCode = facilityCode;
            this.doctor = doctor;
        }

        public AddDoctorEvent(EventData eventData)
        {
            this.MessageID = eventData.MessageID;
            this.FacilityCode = eventData.FacilityCode;
        }

        public string MessageID { get; set; }

        public FacilityCode FacilityCode { get; set; }

        public Doctor doctor { get; }

        public EventType EventType { get; } = EventType.AddDoctor;
    }
}
