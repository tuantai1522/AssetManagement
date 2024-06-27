using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Data.Interfaces;
using AutoMapper;
using System.Text.RegularExpressions;
using AssetManagement.Application.Common.Constants;
using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

    public async Task<PagingDto<CategoryInfoResponse>> GetAllAsync(GetAllCategoryRequest request)
    {
        var queryableSet = _unitOfWork.CategoryRepository.GetQueryableSet();
        var categories = await queryableSet.Skip((request.PageNumber -1) * request.PageSize).Take(request.PageSize).ToListAsync();
        var result = categories.Select(c => _mapper.Map<CategoryInfoResponse>(c)).ToList();
        return new PagingDto<CategoryInfoResponse>
        {
            CurrentPage = request.PageNumber,
            TotalItemCount = queryableSet.Count(),
            PageSize = request.PageSize,
            Data = result
        };
    }
}

