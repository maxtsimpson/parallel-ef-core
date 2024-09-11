namespace parallel.ef.core.Model.Events
{
    public abstract class EventData
    {
        public string MessageID { get; set; }
        public FacilityCode FacilityCode { get; set; }

        public EventType EventType { get; }

    }
}