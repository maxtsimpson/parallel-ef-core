using parallel.ef.core.Handlers;

namespace parallel.ef.core.Services
{
    public interface IEventRouter
    {
        Task ProcessEvent(IEventData messageEvent);

        IEventHandler<IEventData>? GetEventHandler(EventType eventType);
    }
}
