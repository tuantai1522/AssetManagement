using AssetManagement.Application.Common;
using AssetManagement.Application.Services.Interfaces;
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