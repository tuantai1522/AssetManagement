using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAssetService
    {
        Task<AssetDetailsResponse> GetAssetByIdAsync(AssetDetailsRequest request);
    }
}
