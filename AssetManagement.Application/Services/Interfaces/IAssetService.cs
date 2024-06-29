using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAssetService
    {
        Task<AssetResponse> CreateAssetAsync(AssetCreationRequest request);
        Task<PagingDto<FilterAssetResponse>> FilterAssetAsync(FilterAssetRequest filter);
        Task<AssetDetailsResponse> GetAssetByIdAsync(AssetDetailsRequest request);
        Task UpdateAssetAsync(AssetUpdateRequest request);
    }
}
