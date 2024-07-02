using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAssignmentService
    {
        Task<bool> CreateAssignmentAsync(AssignmentCreationRequest request);
    }
}