
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
        //Asset
        CreateMap<AssetCreationRequest, Asset>();
        CreateMap<Asset, AssetResponse>();
        CreateMap<Asset, AssetDetailsResponse>()
            .ForMember(des => des.AssetName, act => act.MapFrom(src => src.Name))
            .ForMember(des => des.CategoryName, act => act.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty));

        //Category
        CreateMap<Category, CategoryInfoResponse>();


    }
}
