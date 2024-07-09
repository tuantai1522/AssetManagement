using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;

namespace AssetManagement.Data.Repositories;
public class UnitOfWork : IUnitOfWork, IAsyncDisposable {
    private readonly AssetManagementDbContext _dbContext;
    public IAssetRepository AssetRepository { get; private set; }
    public ICategoryRepository CategoryRepository { get; private set; }
    public IAssignmentRepository AssignmentRepository { get; private set; }
    public IReturningRequestRepository ReturningRequestRepository { get; }

    public UnitOfWork(AssetManagementDbContext dbContext) {
        _dbContext = dbContext;
        AssetRepository = new AssetRepository(dbContext);
        CategoryRepository = new CategoryRepository(dbContext);
        AssignmentRepository = new AssignmentRepository(dbContext);
        ReturningRequestRepository = new ReturningRequestRepository(dbContext);
    }

    public async Task SaveChangesAsync() {
        await _dbContext.SaveChangesAsync();

    }

    public async ValueTask DisposeAsync() {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    private bool disposed = false;
    protected virtual async Task DisposeAsync(bool disposing) {
        if (!this.disposed) {
            if (disposing) {
                await _dbContext.DisposeAsync();
            }
        }

        this.disposed = true;

        await Task.CompletedTask;
    }

}
