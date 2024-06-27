namespace AssetManagement.Data.Interfaces;
public interface IUnitOfWork
{
    public ICategoryRepository CategoryRepository { get; }
    public IAssetRepository AssetRepository { get; }

    Task SaveChangesAsync();
    ValueTask DisposeAsync();
}
