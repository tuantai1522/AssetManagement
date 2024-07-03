using AssetManagement.Application.Common;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/assignment")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [HttpPost("create")]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
        public async Task<ActionResult<BaseResult<AssetResponse>>> CreateAssetAsync([FromBody] AssignmentCreationRequest request)
        {
            var newAssignmentId = await _assignmentService.CreateAssignmentAsync(request);
            var result = new BaseResult<AssetResponse>()
            {
                IsSuccess = true,
                Error = null,
                Result = null
            };
            return Created($"assignment/{newAssignmentId}", result);
        }
    }
}