using Microsoft.AspNetCore.Mvc;
using System.Net;
using parallel.ef.core.Model;
using Swashbuckle.AspNetCore.Annotations;
using parallel.ef.core.Services;
using parallel.ef.core.Model.Events;

namespace parallel.ef.core.Controllers
{
    [ApiController]
    public class EventController: ControllerBase
    {
        private readonly ILogger<EventController> _logger;
        private readonly IEventRouter _eventRouter;

        public EventController(ILogger<EventController> logger, IEventRouter eventRouter)
        {
            _logger = logger;
            _eventRouter = eventRouter;
        }

        [HttpPost("PostMessageEvent")]
        [SwaggerOperation(Summary = "Post a message event for processing")]
        public async Task<ActionResult<EventData>> PostMessage(EventData eventData)
        {
            _logger.LogInformation("request message received");

            //call event handlers in sequence that handle this type of event message
            await _eventRouter.ProcessSingleEvent(eventData);
            
            return Ok();
        }
    }
}
