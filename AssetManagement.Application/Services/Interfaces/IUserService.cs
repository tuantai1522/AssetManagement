using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;

namespace AssetManagement.Application.Services.Interfaces;
public interface IUserService
{
    Task<PagingDto<FilterUserDto>> FilterUserAsync(FilterUserRequestDto filter);
}
