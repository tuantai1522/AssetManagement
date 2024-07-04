
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Responses;
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

		//Assignment
		CreateMap<Assignment, AssignmentDetailResponse>()
			.ForMember(des => des.AssetCode, act => act.MapFrom(src => src.Asset != null ? src.Asset.AssetCode : string.Empty))
			.ForMember(des => des.AssetName, act => act.MapFrom(src => src.Asset != null ? src.Asset.Name : string.Empty))
			.ForMember(des => des.Specification, act => act.MapFrom(src => src.Asset != null ? src.Asset.Specification : string.Empty))
			.ForMember(des => des.AssignedTo, act => act.MapFrom(src => src.AssignedToUser != null ? src.AssignedToUser.UserName : string.Empty))
			.ForMember(des => des.AssignedBy, act => act.MapFrom(src => src.AssignedByUser != null ? src.AssignedByUser.UserName : string.Empty));
	}
}
