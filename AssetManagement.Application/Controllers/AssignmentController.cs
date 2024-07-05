using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Domain.Constants;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers {
    [Route("api/assignment")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;
        public AssignmentController(IAssignmentService assignment)
        {
            _assignmentService = assignment;
        }
        [HttpGet]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
        public async Task<ActionResult<BaseResult<PagingDto<FilterAssignmentResponse>>>> GetAllAsync([FromQuery] FilterAssignmentRequest request) 
        {
            var data = await _assignmentService.FilterAssignmentAsync(request);
            PaginationMetaData metaData = new PaginationMetaData(data.TotalItemCount, data.PageSize, data.CurrentPage);
            Response.AddPaginationHeader(metaData);

            var result = new BaseResult<List<FilterAssignmentResponse>>()
            {
                IsSuccess = true,
                Error = null,
                Result = data.Data
            };
            return Ok(result);
        }
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<BaseResult<AssignmentDetailResponse>>> GetAssignmentByIdAsync([FromRoute]Guid id)
        {
            var data = await _assignmentService.GetAssignmentByIdAsync(id);
            var result = new BaseResult<AssignmentDetailResponse>()
            {
                IsSuccess = true,
                Result = data,
                Error = null
            };
            return Ok(result);
        }
        [HttpGet("account")]
        [Authorize]
        public async Task<ActionResult<BaseResult<List<FilterUserResponse>>>> GetAllAsync([FromQuery] FilterMyAssignmentRequest request)
        {
            var data = await _assignmentService.FilterMyAssignmentAsync(request);
            PaginationMetaData metaData = new PaginationMetaData(data.TotalItemCount, data.PageSize, data.CurrentPage);
            Response.AddPaginationHeader(metaData);

            var result = new BaseResult<List<FilterMyAssignmentResponse>>()
            {
                IsSuccess = true,
                Error = null,
                Result = data.Data
            };
            return Ok(result);
        }
        [HttpPost("create")]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
        public async Task<ActionResult<BaseResult<bool>>> CreateAssignmentAsync([FromBody] AssignmentCreationRequest request) 
        {
            var newAssignmentId = await _assignmentService.CreateAssignmentAsync(request);
            var result = new BaseResult<bool>()
            {
                IsSuccess = true,
                Error = null,
                Result = true
            };
            return Created($"assignment/{newAssignmentId}", result);
        }
    }
}
