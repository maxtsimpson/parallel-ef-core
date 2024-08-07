using parallel.ef.core.Model.Events;
using parallel.ef.core.Services;
using System;

namespace parallel.ef.core.Handlers
{
    public class AddDoctorHandler : IEventHandler<AddDoctorEvent>
    {
        private readonly IDoctorService _doctorService;

        public AddDoctorHandler(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public async Task ProcessEvent(AddDoctorEvent updateDoctorEvent)
        {
            await _doctorService.UpdateDoctor(updateDoctorEvent.doctor);
        }
    }
}