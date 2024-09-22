using AirlineWeb.Data;
using AirlineWeb.Dtos;
using AirlineWeb.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AirlineWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightController(AirlineDbContext context, IMapper mapper) : ControllerBase
{
    [HttpGet("{flightCode}", Name = "get-flight-details-by-code")]
    public async Task<ActionResult<FlightDetailsReadDto>> GetSubscriptionBySecret(string flightCode)
    {
        var flightDetails =
            await context.FlightDetails.FirstOrDefaultAsync(x =>
                x.FlightCode == flightCode);
        if (flightDetails is null)
            return NotFound();

        var flightDetailsReadDto = mapper.Map<FlightDetailsReadDto>(flightDetails);
        return (flightDetailsReadDto);
    }

    [HttpPost]
    public async Task<ActionResult<FlightDetailsReadDto>> CreateFlight(
        [FromBody] FlightDetailsCreateDto flightDetailsCreateDto)
    {
        var flightDetails =
            await context.FlightDetails.FirstOrDefaultAsync(x =>
                x.FlightCode == flightDetailsCreateDto.FlightCode);
        if (flightDetails is null)
        {
            flightDetails = mapper.Map<FlightDetails>(flightDetailsCreateDto);

            await context.FlightDetails.AddAsync(flightDetails);
            await context.SaveChangesAsync();

            var flightDetailsReadDto = mapper.Map<FlightDetailsReadDto>(flightDetails);
            return Ok(flightDetailsReadDto);
        }
        else
        {
            return NoContent();
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<FlightDetailsReadDto>> UpdateFlight( int id , 
        [FromBody] FlightDetailsUpdateDto flightDetailsUpdateDto)
    {
        var flightDetails =
            await context.FlightDetails.FirstOrDefaultAsync(x =>
                x.Id == id);
        if (flightDetails is null)
            return NotFound();
        
        mapper.Map(flightDetailsUpdateDto,flightDetails);
        context.FlightDetails.Update(flightDetails);
        await context.SaveChangesAsync();
        
        return  mapper.Map<FlightDetailsReadDto>(flightDetails);
    }
}