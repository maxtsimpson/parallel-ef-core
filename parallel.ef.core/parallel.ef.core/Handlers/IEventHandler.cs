using parallel.ef.core.Model.Events;

namespace parallel.ef.core.Handlers
{
    public interface IEventHandler<T> where T : EventData
    {
        Task ProcessEvent(T eventData);
    }
}
