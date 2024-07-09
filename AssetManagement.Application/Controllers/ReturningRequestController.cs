using AssetManagement.Application.Common;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/return-request")]
    [ApiController]
    public class ReturningRequestController : ControllerBase
    {

        private readonly IReturningRequestService _returningRequestService;

        public ReturningRequestController(IReturningRequestService returningRequestService)
        {
            _returningRequestService = returningRequestService;
        }

        [HttpPost("user-create-request/{assignmentId}")]
        [Authorize(Roles = $"{RoleConstant.StaffRole}")]
        public async Task<ActionResult<BaseResult<object>>> CreateRequestByUserAsync([FromRoute] Guid assignmentId)
        {
            await _returningRequestService.CreateRequestByUserAsync(assignmentId);
            var result = new BaseResult<object>()
            {
                IsSuccess = true,
                Error = null,
                Result = null,
            };
            return Ok(result);
        }
    }
}
