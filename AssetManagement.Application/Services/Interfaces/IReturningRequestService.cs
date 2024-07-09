namespace AssetManagement.Application.Services.Interfaces
{
    public interface IReturningRequestService
    {
        Task CreateRequestByAdminAsync(Guid id);
    }
}
