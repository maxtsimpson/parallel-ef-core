using parallel.ef.core.Model.Events;
using parallel.ef.core.Services;
using System;

namespace parallel.ef.core.Handlers
{
    public class UpdateDoctorHandler : IEventHandler<UpdateDoctorEvent>
    {
        private readonly IDoctorService _doctorService;

        public UpdateDoctorHandler(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public async Task ProcessEvent(UpdateDoctorEvent updateDoctorEvent)
        {
            await _doctorService.UpdateDoctor(updateDoctorEvent.doctor);
        }
    }

}