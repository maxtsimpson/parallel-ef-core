using parallel.ef.core.Handlers;
using parallel.ef.core.Services;
using System.Text.Json;

public class EventRouter : IEventRouter
{
    private readonly ILogger<EventRouter> _logger;
    private readonly IDictionary<EventType,IEventHandler<IEventData>> _handlers;

    public EventRouter(IDictionary<EventType, IEventHandler<IEventData>> eventHandlers, ILogger<EventRouter> logger)
    {
        _logger = logger;
        _handlers = eventHandlers;
    }

    public IEventHandler<IEventData>? GetEventHandler(EventType eventType)
    {
        return _handlers[eventType];
    }

    public async Task ProcessEvent(IEventData eventData)
    {
        try
        {
            var handler = GetEventHandler(eventData.EventType);
            if (handler == null)
                return;

            await handler.ProcessEvent(eventData);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "error trying to process event {0}", JsonSerializer.Serialize(eventData));
            throw;
        }
        
    }
}