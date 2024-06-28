using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ICollection<CategoryInfoResponse>>> GetAllAsync([FromQuery] GetAllCategoryRequest request)
        {
            var data = await _categoryService.GetAllAsync(request);
            PaginationMetaData metaData = new(data.TotalItemCount, data.PageSize, data.CurrentPage);
            Response.AddPaginationHeader(metaData);

            var result = new BaseResult<List<CategoryInfoResponse>>()
            {
                IsSuccess = true,
                Error = null,
                Result = data.Data
            };
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
        public async Task<ActionResult<CategoryInfoResponse>> CreateAsync(CreateCategoryRequest request)
        {
            var data = await _categoryService.CreateAsync(request);
            var result = new BaseResult<CategoryInfoResponse>()
            {
                IsSuccess = true,
                Error = null,
                Result = data
            };
            return Ok(result);
        }
    }
}
