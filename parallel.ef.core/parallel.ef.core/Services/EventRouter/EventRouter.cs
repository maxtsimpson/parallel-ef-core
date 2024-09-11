using Microsoft.Extensions.DependencyInjection;
using parallel.ef.core.Handlers;
using parallel.ef.core.Model.Events;
using parallel.ef.core.Services;
using System.Linq;
using System.Text.Json;

public class EventRouter : IEventRouter
{
    private readonly ILogger<EventRouter> _logger;
    private readonly IEventHandler<AddDoctorEvent> _addDoctorHandler;
    private readonly IEventHandler<UpdateDoctorEvent> _updateDoctorHandler;


    public EventRouter(ILogger<EventRouter> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _addDoctorHandler = serviceProvider.GetRequiredService<IEventHandler<AddDoctorEvent>>();
        _updateDoctorHandler = serviceProvider.GetRequiredService<IEventHandler<UpdateDoctorEvent>>();
    }

    public async Task ProcessSingleEvent(EventData eventData)
    {
        try
        {
            // var handler = GetEventHandler(eventData.EventType);
            
            switch (eventData.EventType)
            {
                case EventType.CreateDoctor:
                    await _addDoctorHandler.ProcessEvent(eventData);
                    break;
                case EventType.UpdateDoctor:
                    await _updateDoctorHandler.ProcessEvent(eventData as UpdateDoctorEvent);
                    break;
            }

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

    // public async Task ProcessMultipleEvents(EventData[] events)
    // {
    //     try
    //     {
    //         //foreach event if the next event is for the 
    //         List<FacilityCode> facilityCodesInUse = new List<FacilityCode>();
    //         List<Task> tasksBeingProcessed = new List<Task>();
    //         Dictionary<FacilityCode, Task> facilityCodeTasks = new Dictionary<FacilityCode, Task>();

    //         for (int i = 0; i < events.Length; i++)
    //         {
    //             var item = events[i];
    //             var thisFacilityCode = item.FacilityCode;

    //             if (facilityCodeTasks.ContainsKey(thisFacilityCode))
    //             {
    //                 var currentRunningTask = facilityCodeTasks[thisFacilityCode];
    //                 currentRunningTask.Wait();
    //                 facilityCodeTasks.Remove(thisFacilityCode);
    //             }
    //             var task = handleSingleEvent(item);
    //             task.Start();
    //             facilityCodeTasks.Add(thisFacilityCode, task);
    //         }
    //     }
    //     catch (Exception ex)
    //     {
    //         _logger.LogError(ex, "error trying to process event {0}", JsonSerializer.Serialize(events));
    //         throw;
    //     }

    // }

    // private async Task handleSingleEvent(EventData eventData)
    // {
    //     try
    //     {
    //         var handler = GetEventHandler(eventData.EventType);
    //         if (handler == null)
    //             return;

    //         await handler.ProcessEvent(eventData);
    //     }
    //     catch (Exception ex)
    //     {
    //         _logger.LogError(ex, "error trying to process event {0}", JsonSerializer.Serialize(eventData));
    //         throw;
    //     }
    // }
}