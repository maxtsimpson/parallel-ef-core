using parallel.ef.core.Handlers;
using parallel.ef.core.Services;
using System.Linq;
using System.Text.Json;

public class EventRouter : IEventRouter
{
    private readonly ILogger<EventRouter> _logger;
    private readonly IDictionary<EventType, IEventHandler<IEventData>> _handlers;

    public EventRouter(IDictionary<EventType, IEventHandler<IEventData>> eventHandlers, ILogger<EventRouter> logger)
    {
        _logger = logger;
        _handlers = eventHandlers;
    }

    public IEventHandler<IEventData>? GetEventHandler(EventType eventType)
    {
        return _handlers[eventType];
    }

    public async Task ProcessSingleEvent(IEventData eventData)
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

    //we should just have one Events task available that takes a list which has one or more events
    // the facilityCodeTasks dictionary should be moved to a private property of the event router

    //TODO: add a class that registers the event handler dictionary as a service so it can be injected into the 
    // event router

    // probably should look at making this event router a singleton as well
    // or potentially limit the event router to a set of facility codes and have multiple event router instances, one per facility code

    public async Task ProcessMultipleEvents(IEventData[] events)
    {
        try
        {
            //foreach event if the next event is for the 
            List<FacilityCode> facilityCodesInUse = new List<FacilityCode>();
            List<Task> tasksBeingProcessed = new List<Task>();
            Dictionary<FacilityCode, Task> facilityCodeTasks = new Dictionary<FacilityCode, Task>();

            for (int i = 0; i < events.Length; i++)
            {
                var item = events[i];
                var thisFacilityCode = item.FacilityCode;

                if (facilityCodeTasks.ContainsKey(thisFacilityCode))
                {
                    var currentRunningTask = facilityCodeTasks[thisFacilityCode];
                    currentRunningTask.Wait();
                    facilityCodeTasks.Remove(thisFacilityCode);
                }
                var task = handleSingleEvent(item);
                task.Start();
                facilityCodeTasks.Add(thisFacilityCode, task);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "error trying to process event {0}", JsonSerializer.Serialize(eventData));
            throw;
        }

    }

    private async Task handleSingleEvent(IEventData eventData)
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