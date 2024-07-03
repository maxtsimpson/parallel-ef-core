using parallel.ef.core.Services;

public class EventRouter : IEventRouter
{
    public async Task<bool> ProcessEvent(EventData messageEvent)
    {
        bool isSuccessfullyProcessed = false;

		try
		{
            if (messageEvent.EventType == EventType.UpdateDoctor)
            {

            }

            switch (messageEvent.FacilityCode)
            {
                case FacilityCode.South:
                    // Code for Facility Code 1
                    break;
                case FacilityCode.North:
                    // Code for Facility Code 2
                    break;
                case FacilityCode.East:
                    // Code for Facility Code 3
                    break;
                case FacilityCode.West:
                    // Code for Facility Code 3
                    break;
                // Add more cases for other Facility Codes as needed
                default:
                    // Code for handling unknown Facility Codes
                    break;
            }
            isSuccessfullyProcessed = true;
        }
		catch (Exception)
		{

			return false;
		}

        return isSuccessfullyProcessed;
    }
}