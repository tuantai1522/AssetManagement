using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;

namespace AssetManagement.Application.Services.Interfaces;

public interface IAssignmentService
{
    Task<PagingDto<FilterAssignmentResponse>> FilterAssignmentAsync(FilterAssignmentRequest filter);
    Task<AssignmentDetailResponse> GetAssignmentByIdAsync(Guid assignmentId);
    Task<Guid> CreateAssignmentAsync(AssignmentCreationRequest request);
    Task<PagingDto<FilterMyAssignmentResponse>> FilterMyAssignmentAsync(FilterMyAssignmentRequest filter);
    Task<bool> RespondAsync(string assignmentId, RespondAssignmentRequest request);
}

