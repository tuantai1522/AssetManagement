using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet()]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<List<FilterUserResponse>>>> GetAsync([FromQuery] FilterUserRequest request)
    {
        var data = await _userService.FilterUserAsync(request);
        PaginationMetaData metaData = new PaginationMetaData(data.TotalItemCount, data.PageSize, data.CurrentPage);
        Response.AddPaginationHeader(metaData);

        var result = new BaseResult<List<FilterUserResponse>>()
        {
            IsSuccess = true,
            Error = null,
            Result = data.Data
        };
        return Ok(result);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<UserInfoResponse>>> GetUserInfoAsync([FromRoute] Guid id)
    {
        var data = await _userService.GetUserById(id);
        var result = new BaseResult<UserInfoResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }
    
    [HttpPost]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<IActionResult> Disable([FromBody] UserDisableRequest request)
    {
        throw new NotImplementedException();
    }
}

