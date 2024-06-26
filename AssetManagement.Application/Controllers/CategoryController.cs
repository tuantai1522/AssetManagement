using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Contracts.Dtos.CategoryDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<CategoryInfoResponse>>> GetAllAsync([FromQuery] GetAllCategoryRequest request)
        {
            var data = await _categoryService.GetAllAsync(request);
            PaginationMetaData metaData = new PaginationMetaData(data.TotalItemCount, data.PageSize, data.CurrentPage);
            Response.AddPaginationHeader(metaData);

            var result = new BaseResult<List<CategoryInfoResponse>>()
            {
                IsSuccess = true,
                Error = null,
                Result = data.Data
            };
            return Ok(result);
        }
    }
}
