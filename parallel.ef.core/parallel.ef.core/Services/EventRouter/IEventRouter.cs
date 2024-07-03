namespace parallel.ef.core.Services
{
    public interface IEventRouter
    {
        Task<bool> ProcessEvent(EventData messageEvent);
    }
}
