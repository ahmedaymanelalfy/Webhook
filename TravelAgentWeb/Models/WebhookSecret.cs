using System.ComponentModel.DataAnnotations;

namespace TravelAgentWeb.Models;

public class WebhookSecret
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public required string Secret { get; set; }  

    [Required]
    public required string Publisher { get; set; }
}