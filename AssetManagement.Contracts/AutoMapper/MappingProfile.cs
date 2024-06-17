using AssetManagement.Contracts.Dtos.WeatherForecastDtos;
using AssetManagement.Domain.Entities;
using AutoMapper;

namespace AssetManagement.Contracts.AutoMapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //WeatherForcast
        CreateMap<WeatherForecast, WeatherForecastResponseDto>();
    }
}
