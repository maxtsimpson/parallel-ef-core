using parallel.ef.core.Model.Events;

public interface IRequest
{
    public EventData[] eventData { get; set; }
}