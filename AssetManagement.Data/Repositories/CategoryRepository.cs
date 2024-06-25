using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using AssetManagement.Data.Repositories.Base;
using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly AssetManagementDbContext _context;
        public CategoryRepository(AssetManagementDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
