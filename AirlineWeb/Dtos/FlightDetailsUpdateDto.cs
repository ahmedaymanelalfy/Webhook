namespace AirlineWeb.Dtos;

public class FlightDetailsUpdateDto
{
    public int Id { get; set; }
    public required string FlightCode { get; set; }
    public decimal Price { get; set; }
}