namespace AssetManagement.Application.Services.Interfaces
{
    public interface IReturningRequestService
    {
        Task CreateRequestByUserAsync(Guid id);
    }
}
