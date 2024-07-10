using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using AssetManagement.Data.Repositories.Base;
using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories {
    public class ReturningRequestRepository : GenericRepository<ReturningRequest>, IReturningRequestRepository {
        public ReturningRequestRepository(AssetManagementDbContext context) : base(context) { }

		public async Task<ReturningRequest?> GetRequestByIdAsync(Guid id)
		{
			IQueryable<ReturningRequest> query = dbSet;
			query = query.Where(q => q.Id == id);
			query = query
				.Include(q => q.Assignment).ThenInclude(a => a.Asset);
			return await query.FirstOrDefaultAsync();
		}
	}
}
