using AssetManagement.Application.Common;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
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
