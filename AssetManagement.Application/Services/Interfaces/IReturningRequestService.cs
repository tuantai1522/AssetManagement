namespace AssetManagement.Application.Services.Interfaces {
    public interface IReturningRequestService {
        Task CompleteReturnRequestByIdAsync(Guid requestId);
    }
}
