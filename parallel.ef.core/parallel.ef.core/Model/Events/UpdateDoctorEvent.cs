namespace parallel.ef.core.Model.Events
{
    public class UpdateDoctorEvent: EventData
    {
        public UpdateDoctorEvent(string messageID, FacilityCode facilityCode, Doctor doctor)
        {
            MessageID = messageID;
            FacilityCode = facilityCode;
            this.doctor = doctor;
        }

        public Doctor doctor { get; }

    }
}
