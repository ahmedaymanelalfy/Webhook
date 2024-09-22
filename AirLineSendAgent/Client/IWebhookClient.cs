using AirLineSendAgent.Dtos;

namespace AirLineSendAgent.Client;

public interface IWebhookClient
{
    Task SendWebhookNotification(FlightDetailChangePayloadDto flightDetailChangePayloadDto);
}