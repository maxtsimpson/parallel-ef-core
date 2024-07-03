public interface IRequest
{
    public EventData eventData { get; set; }
    public object requestBody { get; set; }
}