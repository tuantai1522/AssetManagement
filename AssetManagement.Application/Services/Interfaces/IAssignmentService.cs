using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAssignmentService
    {
        Task<Guid> CreateAssignmentAsync(AssignmentCreationRequest request);
    }
}