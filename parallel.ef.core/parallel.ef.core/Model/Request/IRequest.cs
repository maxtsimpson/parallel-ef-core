using parallel.ef.core.Model.Request;

public interface IRequest
{
    public IEventData eventData { get; set; }
}