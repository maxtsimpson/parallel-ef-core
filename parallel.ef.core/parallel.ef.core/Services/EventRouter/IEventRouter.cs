using parallel.ef.core.Handlers;

namespace parallel.ef.core.Services
{
    public interface IEventRouter
    {
        Task ProcessSingleEvent(IEventData messageEvent);

        Task ProcessMultipleEvents(IEventData[] messageEvents);

        IEventHandler<IEventData>? GetEventHandler(EventType eventType);
    }
}
