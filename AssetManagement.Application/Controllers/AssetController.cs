using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers;

[Route("api/asset")]
[ApiController]
public class AssetController : ControllerBase
{
    private readonly IAssetService _assetService;

    public AssetController(IAssetService assetService)
    {
        _assetService = assetService;
    }

    [HttpGet]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<List<FilterUserResponse>>>> GetAllAsync([FromQuery] FilterAssetRequest request)
    {
        var data = await _assetService.FilterAssetAsync(request);
        PaginationMetaData metaData = new PaginationMetaData(data.TotalItemCount, data.PageSize, data.CurrentPage);
        Response.AddPaginationHeader(metaData);

        var result = new BaseResult<List<FilterAssetResponse>>()
        {
            IsSuccess = true,
            Error = null,
            Result = data.Data
        };
        return Ok(result);
    }

    [HttpGet("getAssetById")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<AssetDetailsResponse>>> GetAssetById([FromQuery] AssetDetailsRequest request)
    {
        var data = await _assetService.GetAssetByIdAsync(request);
        var result = new BaseResult<AssetDetailsResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }

    [HttpPut("updateAssetById")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<object>>> UpdateAssetById([FromBody] AssetUpdateRequest request)
    {
        await _assetService.UpdateAssetAsync(request);
        var result = new BaseResult<object>()
        {
            IsSuccess = true,
            Error = null,
            Result = null,
        };
        return Ok(result);
    }

    [HttpPost("create")]
    [Authorize(Roles = $"{RoleConstant.AdminRole}")]
    public async Task<ActionResult<BaseResult<AssetResponse>>> CreateAssetAsync([FromBody] AssetCreationRequest request)
    {
        var data = await _assetService.CreateAssetAsync(request);
        var result = new BaseResult<AssetResponse>()
        {
            IsSuccess = true,
            Error = null,
            Result = data
        };
        return Ok(result);
    }
}
