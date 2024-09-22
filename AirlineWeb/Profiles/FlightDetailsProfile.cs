using AirlineWeb.Dtos;
using AirlineWeb.Models;
using AutoMapper;

namespace AirlineWeb.Profiles;

public class FlightDetailsProfile : Profile
{
    public FlightDetailsProfile()
    {
        CreateMap<FlightDetails, FlightDetailsReadDto>();
        CreateMap<FlightDetailsCreateDto, FlightDetails>();
        CreateMap<FlightDetailsUpdateDto, FlightDetails>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

    }
}