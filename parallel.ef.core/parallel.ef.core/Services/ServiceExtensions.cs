using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyModel;
using parallel.ef.core.Handlers;
using parallel.ef.core.Model.Events;
using System;
using System.Diagnostics;

namespace parallel.ef.core.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            IDictionary<EventType, IEventHandler<IEventData>> _handlers = new Dictionary<EventType, IEventHandler<IEventData>>();

            services.AddScoped<AddDoctorHandler>();
            services.AddScoped<UpdateDoctorHandler>();

            

            return services;
        }

    }
}
