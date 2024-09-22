using System.ComponentModel.DataAnnotations;

namespace AirlineWeb.Dtos;

public class FlightDetailsCreateDto
{
    [Required]
    public required string FlightCode { get; set; }
    [Required]
    public decimal Price { get; set; }
}