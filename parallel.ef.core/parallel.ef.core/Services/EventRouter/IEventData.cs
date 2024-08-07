using parallel.ef.core.Model;

public interface IEventData
{
    public string MessageID { get; set; }
    public FacilityCode FacilityCode { get; set; }

    public EventType EventType { get; }

}