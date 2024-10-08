﻿using Microsoft.AspNetCore.Mvc;
using parallel.ef.core.Handlers;
using parallel.ef.core.Model;
using parallel.ef.core.Model.Events;
using parallel.ef.core.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace parallel.ef.core.Controllers
{
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ILogger<DoctorController> _logger;
        private readonly IEventRouter _eventRouter;

        public DoctorController(ILogger<DoctorController> logger, IEventRouter eventRouter )
        {
            _logger = logger;
            _eventRouter = eventRouter;
        }

        [HttpPost("UpdateDoctor")]
        [SwaggerOperation(Summary = "Post a doctor update event")]
        public async Task<ActionResult<Doctor>> UpdateDoctor(UpdateDoctorEvent updateDoctorEvent)
        {
            _logger.LogInformation("request message received");

            //call event handlers in sequence that handle this type of event message
            
            await _eventRouter.ProcessSingleEvent(updateDoctorEvent);

            return Ok();
        }
    }
}
