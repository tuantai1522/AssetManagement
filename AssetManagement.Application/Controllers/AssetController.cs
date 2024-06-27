using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers;

[Route("api/[controller]")]
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
