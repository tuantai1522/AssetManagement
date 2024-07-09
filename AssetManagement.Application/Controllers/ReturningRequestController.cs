using AssetManagement.Application.Common;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Responses;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers {
    [Route("api/return-request")]
    [ApiController]
    public class ReturningRequestController : ControllerBase {

        private readonly IReturningRequestService _returningRequestService;

        public ReturningRequestController(IReturningRequestService returningRequestService) {
            _returningRequestService = returningRequestService;
		}
		[HttpPut]
		[Route("complete/{id}")]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
		public async Task<ActionResult<BaseResult<Object>>> CompleteRequestRequestByIdAsync(Guid id)
		{
			await _returningRequestService.CompleteReturnRequestByIdAsync(id);
			var result = new BaseResult<object>()
			{
				IsSuccess = true,
				Error = null,
				Result = new object()
			};
			return Ok(result);
		}
	}
}
