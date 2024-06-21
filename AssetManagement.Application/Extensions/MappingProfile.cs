
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Entities;
using AutoMapper;

namespace AssetManagement.Application.Extensions;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AppUser, UserInfoResponse>()
            .ForMember(dest => dest.FullName, src => src.MapFrom(src => string.Concat(src.LastName, " ", src.FirstName)))
            .ForMember(dest => dest.Types, src => src.MapFrom(src => src.UserRoles.FirstOrDefault().Role.Name));
    }
}