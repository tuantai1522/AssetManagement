
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Entities;
using AutoMapper;

namespace AssetManagement.Application.Extensions;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //User
        CreateMap<AppUser, UserInfoResponse>()
            .ForMember(dest => dest.FullName, src => src.MapFrom(src => string.Concat(src.FirstName, " ", src.LastName)))
            .ForMember(dest => dest.Type, src => src.MapFrom(src => src.UserRoles.FirstOrDefault()!.Role.Name));
        //Category
        CreateMap<Category, CategoryInfoResponse>();

        //Assert
        CreateMap<AssetCreationRequest, Asset>();
        CreateMap<Asset, AssetResponse>();
        CreateMap<Asset, AssetDetailsResponse>()
            .ForMember(des => des.Id, act => act.MapFrom(src => src.Id))
            .ForMember(des => des.AssetCode, act => act.MapFrom(src => src.AssetCode))
            .ForMember(des => des.AssetName, act => act.MapFrom(src => src.Name))
            .ForMember(des => des.CategoryName, act => act.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty))
            .ForMember(des => des.InstalledDate, act => act.MapFrom(src => src.InstalledDate))
            .ForMember(des => des.State, act => act.MapFrom(src => src.State))
            .ForMember(des => des.Location, act => act.MapFrom(src => src.Location))
            .ForMember(des => des.Specification, act => act.MapFrom(src => src.Specification));
    }
}
