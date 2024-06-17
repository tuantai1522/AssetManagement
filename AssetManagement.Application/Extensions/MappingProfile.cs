
using AssetManagement.Contracts.Dtos.WeatherForecastDtos;
using AssetManagement.Domain.Entities;
using AutoMapper;

namespace AssetManagement.Application.Extensions;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //WeatherForcast
        CreateMap<WeatherForecast, WeatherForecastResponseDto>();
    }
}