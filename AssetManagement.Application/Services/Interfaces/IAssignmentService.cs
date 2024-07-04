using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAssignmentService
    {
        Task<Guid> CreateAssignmentAsync(AssignmentCreationRequest request);
        Task<PagingDto<FilterAssignmentResponse>> FilterAssignmentAsync(FilterAssignmentRequest filter);
    }
}
