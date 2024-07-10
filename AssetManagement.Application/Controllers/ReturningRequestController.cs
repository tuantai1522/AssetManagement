﻿using AssetManagement.Application.Common;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Requests;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Responses;
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

        [HttpPost("admin-create-request/{assignmentId}")]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
        public async Task<ActionResult<BaseResult<object>>> CreateRequestByAdminAsync([FromRoute] Guid assignmentId)
        {
            await _returningRequestService.CreateRequestByAdminAsync(assignmentId);
            var result = new BaseResult<object>()
            {
                IsSuccess = true,
                Error = null,
                Result = null,
            };
            return Ok(result);
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConstant.AdminRole}")]
        public async Task<ActionResult<BaseResult<PagingDto<FilterReturningResponse>>>> GetAllAsync([FromQuery] FilterReturningRequest request)
        {
            var data = await _returningRequestService.FilterReturningAsync(request);
            PaginationMetaData metaData = new PaginationMetaData(data.TotalItemCount, data.PageSize, data.CurrentPage);
            Response.AddPaginationHeader(metaData);

            var result = new BaseResult<List<FilterReturningResponse>>()
            {
                IsSuccess = true,
                Error = null,
                Result = data.Data
            };
            return Ok(result);
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

        [HttpPost("user-create-request/{assignmentId}")]
        [Authorize]
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

        [HttpPut]
        [Route("cancel/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<BaseResult<Object>>> CancelRequestForReturningAssignment([FromRoute] Guid id)
        {
            await _returningRequestService.CancelReturningRequest(id);
            var result = new BaseResult<Object>()
            {
                IsSuccess = true,
                Error = null,
                Result = { },
            };
            return Ok(result);
        }
    }
}
