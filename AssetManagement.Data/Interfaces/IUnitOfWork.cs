namespace AssetManagement.Data.Interfaces;
public interface IUnitOfWork
{
    public IAssetRepository AssetRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    Task SaveChangesAsync();
    ValueTask DisposeAsync();
}
