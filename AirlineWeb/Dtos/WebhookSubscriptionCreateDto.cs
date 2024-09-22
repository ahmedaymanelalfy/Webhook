using System.ComponentModel.DataAnnotations;

namespace AirlineWeb.Dtos;

public class WebhookSubscriptionCreateDto
{
    [Required]
    public required string WebhookUri { get; set; }

    [Required]
    public required string WebhookType { get; set; }

}