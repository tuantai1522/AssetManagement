using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Requests;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Responses;

namespace AssetManagement.Application.Services.Interfaces {
    public interface IReturningRequestService {
        Task<PagingDto<FilterReturningResponse>> FilterReturningAsync(FilterReturningRequest filter);
    }
}
