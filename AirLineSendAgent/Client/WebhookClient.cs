using System.Net.Http.Headers;
using System.Text.Json;
using AirLineSendAgent.Dtos;

namespace AirLineSendAgent.Client;

public class WebhookClient : IWebhookClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    public WebhookClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
        
    public async Task SendWebhookNotification(FlightDetailChangePayloadDto flightDetailChangePayloadDto)
    {
        Console.WriteLine("Inside send");
        var serializedPayload = JsonSerializer.Serialize(flightDetailChangePayloadDto);

        var httpClient = _httpClientFactory.CreateClient();

        var request = new HttpRequestMessage(HttpMethod.Post, flightDetailChangePayloadDto.WebhookURI);
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        request.Content = new StringContent(serializedPayload);

        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        try
        {
            using (var response = await httpClient.SendAsync(request))
            {
                Console.WriteLine("Success");
                response.EnsureSuccessStatusCode();
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Unsuccessful {ex.Message}");
        }
    }
}
