using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using Microsoft.Extensions.Logging;

namespace AssetManagement.Data.Repositories;
public class UnitOfWork : IUnitOfWork, IAsyncDisposable
{
    private readonly AssetManagementDbContext _dbContext;
    private readonly ILogger<UnitOfWork> _logger;

    public UnitOfWork(AssetManagementDbContext dbContext, ILogger<UnitOfWork> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsync(true);
        GC.SuppressFinalize(this);
    }

    private bool disposed = false;
    protected virtual async Task DisposeAsync(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                await _dbContext.DisposeAsync();
            }
        }

        this.disposed = true;

        await Task.CompletedTask;
    }

}
