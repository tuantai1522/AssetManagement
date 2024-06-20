namespace AssetManagement.Data.Interfaces;
public interface IUnitOfWork
{
    Task SaveChangesAsync();
    ValueTask DisposeAsync();
}
