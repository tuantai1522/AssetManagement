using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<PagingDto<CategoryInfoResponse>> GetAllAsync(GetAllCategoryRequest request);
        Task<CategoryInfoResponse> CreateAsync(CreateCategoryRequest request);
    }
}
