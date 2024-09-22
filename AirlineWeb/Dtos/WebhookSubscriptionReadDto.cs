namespace AirlineWeb.Dtos;

public class WebhookSubscriptionReadDto
{
    public int Id { get; set; }
    public required string WebhookUri { get; set; }
    public required string Secret { get; set; }
    public required string WebhookType { get; set; }
    public required string WebhookPublisher { get; set; }
}