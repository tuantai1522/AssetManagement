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

[Route("api/users")]
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
        var data = await _userService.GetUserByIdAsync(id);
        var result = new BaseResult<UserInfoResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }

    [HttpPost("create")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<UserInfoResponse>>> CreateUserAsync([FromBody] CreateUserRequest request)
    {
        var data = await _userService.CreateUserAsync(request);
        var result = new BaseResult<UserInfoResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }

    [HttpPut("disable/{id}")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<IActionResult> DisableAsync(Guid id)
    {
        var data = await _userService.DisableUserAsync(id);
        var result = new BaseResult<DisableUserResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }

    [HttpPut]
    [Route("{userId}")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<UserInfoResponse>>> UpdateAsync([FromRoute] Guid userId, [FromBody] UpdateUserRequest request)
    {
        var data = await _userService.UpdateUserAsync(userId, request);
        var result = new BaseResult<UserInfoResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }
}

