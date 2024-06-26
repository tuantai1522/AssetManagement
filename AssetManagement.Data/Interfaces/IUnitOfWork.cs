namespace AssetManagement.Data.Interfaces;
public interface IUnitOfWork
{
    IAssetRepository AssetRepo { get; }
    ICategoryRepository CategoryRepo { get; }
    Task SaveChangesAsync();
    ValueTask DisposeAsync();
}
