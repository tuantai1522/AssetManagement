using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using AssetManagement.Data.Repositories.Base;
using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Repositories
{
    public class AssetRepository : GenericRepository<Asset>, IAssetRepository
    {
        private readonly AssetManagementDbContext _context;
        public AssetRepository(AssetManagementDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
