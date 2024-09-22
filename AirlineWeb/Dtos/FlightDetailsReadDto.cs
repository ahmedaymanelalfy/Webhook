using System.ComponentModel.DataAnnotations;

namespace AirlineWeb.Dtos;

public class FlightDetailsReadDto
{
    public int Id { get; set; }
    public required string FlightCode { get; set; }
    public decimal Price { get; set; }
}