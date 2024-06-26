using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Data.Interfaces;
using AutoMapper;

namespace AssetManagement.Application.Services.Implementations;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper) 
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PagingDto<CategoryInfoResponse>> GetAllAsync(GetAllCategoryRequest? request)
    {
        var categories = await _unitOfWork.CategoryRepository.All();
        var result = categories.Select(c => _mapper.Map<CategoryInfoResponse>(c)).ToList();
        return new PagingDto<CategoryInfoResponse>
        {
            CurrentPage = 1,
            TotalItemCount = result.Count,
            PageSize = result.Count,
            Data = result
        };
    }
}

