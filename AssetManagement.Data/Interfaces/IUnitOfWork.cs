namespace AssetManagement.Data.Interfaces;
public interface IUnitOfWork
{
    public ICategoryRepository CategoryRepository { get; }
    public IAssetRepository AssetRepository { get; }
    public IAssignmentRepository AssignmentRepository { get; }

    Task SaveChangesAsync();
    ValueTask DisposeAsync();
}
