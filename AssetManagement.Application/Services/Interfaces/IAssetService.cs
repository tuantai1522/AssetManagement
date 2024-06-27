using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAssetService
    {
		Task<PagingDto<FilterAssetResponse>> FilterAssetAsync(FilterAssetRequest filter);
	}
}
