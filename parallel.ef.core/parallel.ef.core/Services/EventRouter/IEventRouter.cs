using parallel.ef.core.Handlers;
using parallel.ef.core.Model.Events;

namespace parallel.ef.core.Services
{
    public interface IEventRouter
    {
        Task ProcessSingleEvent(EventData messageEvent);

        // Task ProcessMultipleEvents(EventData[] messageEvents);

    }
}
