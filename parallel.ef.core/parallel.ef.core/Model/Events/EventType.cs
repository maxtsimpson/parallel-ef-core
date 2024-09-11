using System.Text.Json.Serialization;

namespace parallel.ef.core.Model.Events
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EventType
    {
        
        CreateDoctor,
        UpdateDoctor,
        DeleteDoctor,
        GetDoctorById,
        GetAllDoctors,
        AddDoctor
    }
}