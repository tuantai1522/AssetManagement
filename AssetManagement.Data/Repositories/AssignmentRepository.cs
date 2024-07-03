using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using AssetManagement.Data.Repositories.Base;
using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Repositories
{
    public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
    {
        private readonly AssetManagementDbContext _context;
        public AssignmentRepository(AssetManagementDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}