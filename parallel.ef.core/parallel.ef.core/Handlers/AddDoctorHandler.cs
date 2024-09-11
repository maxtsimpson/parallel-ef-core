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

        public async Task ProcessEvent(AddDoctorEvent addDoctorEvent)
        {
            await _doctorService.AddDoctor(addDoctorEvent.doctor, addDoctorEvent.FacilityCode);
        }

        public async Task ProcessEvent(EventData eventData)
        {
            AddDoctorEvent addDoctorEvent = new AddDoctorEvent(eventData);
            await _doctorService.AddDoctor(addDoctorEvent.doctor, addDoctorEvent.FacilityCode);
        }

        // public async Task ProcessEvent(EventData eventData)
        // {
        //     throw new NotImplementedException();
        // }
    }
}