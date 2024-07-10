using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Requests;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Responses;
using System.Threading.Tasks;
using System;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IReturningRequestService
    {
        Task CompleteReturnRequestByIdAsync(Guid requestId);
        Task<PagingDto<FilterReturningResponse>> FilterReturningAsync(FilterReturningRequest filter);
        Task CreateRequestByAdminAsync(Guid id);
        Task CreateRequestByUserAsync(Guid id);
    }
}
