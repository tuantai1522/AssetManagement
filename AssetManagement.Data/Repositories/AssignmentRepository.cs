using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using AssetManagement.Data.Repositories.Base;
using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace AssetManagement.Data.Repositories
{
    public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
    {
        private readonly AssetManagementDbContext _context;
        public AssignmentRepository(AssetManagementDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
		public async Task<Assignment?> GetAssignmentByIdAsync(Guid id)
		{
			IQueryable<Assignment> query = dbSet;
            query = query.Where(q => q.Id  == id);
            query = query.Include(q => q.Asset).Include(q => q.AssignedToUser).Include(q => q.AssignedByUser);
            return await query.FirstOrDefaultAsync();
		}
	}
}