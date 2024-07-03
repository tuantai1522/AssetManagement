using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Application.Common.Validations;
using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Exceptions;
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
        var categories = await queryableSet.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        var result = categories.Select(c => _mapper.Map<CategoryInfoResponse>(c)).ToList();
        return new PagingDto<CategoryInfoResponse>
        {
            CurrentPage = request.PageNumber,
            TotalItemCount = queryableSet.Count(),
            PageSize = request.PageSize,
            Data = result
        };
    }

    public async Task<CategoryInfoResponse> CreateAsync(CreateCategoryRequest request)
    {
        if (!Regex.IsMatch(request.Name, RegexPatterns.AlphabetWhiteSpaceAndNumber)) throw new BadRequestException(ErrorStrings.INVALID_CATEGORY_NAME_CHARACTERS);
        if (!Regex.IsMatch(request.Prefix, RegexPatterns.AlphabetAndNumber)) throw new BadRequestException(ErrorStrings.INVALID_CATEGORY_PREFIX_CHARACTERS);
        var categoryWithSameName = await _unitOfWork.CategoryRepository.FindOne(c => c.Name == request.Name);
        if (categoryWithSameName != null) throw new BadRequestException(ErrorStrings.CATEGORY_NAME_ALREADY_EXISTS);
        var categoryWithSamePrefix = await _unitOfWork.CategoryRepository.FindOne(c => c.Prefix == request.Prefix);
        if (categoryWithSamePrefix != null) throw new BadRequestException(ErrorStrings.CATEGORY_PREFIX_ALREADY_EXISTS);

        var category = new Category
        {
            Name = request.Name,
            Prefix = request.Prefix.ToUpper(),
        };
        var result = _unitOfWork.CategoryRepository.Add(category);
        await _unitOfWork.SaveChangesAsync();
        return _mapper.Map<CategoryInfoResponse>(result);
    }
}

