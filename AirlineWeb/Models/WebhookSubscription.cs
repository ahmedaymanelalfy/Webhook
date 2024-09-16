using System.ComponentModel.DataAnnotations;

namespace AirlineWeb.Models
{
    public class WebhookSubscription
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public required string WebhookURI { get; set; }

        [Required]
        public required string Secret { get; set; }

        [Required]
        public required string WebhookType { get; set; }

        [Required]
        public required string WebhookPublisher { get; set; }
    }
}