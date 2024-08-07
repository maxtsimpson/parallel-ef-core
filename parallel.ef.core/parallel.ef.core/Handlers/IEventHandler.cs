namespace parallel.ef.core.Handlers
{
    public interface IEventHandler<T> where T : IEventData
    {
        Task ProcessEvent(T eventData);
    }
}
