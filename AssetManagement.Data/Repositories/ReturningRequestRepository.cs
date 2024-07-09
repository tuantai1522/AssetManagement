using AssetManagement.Data.Data;
using AssetManagement.Data.Interfaces;
using AssetManagement.Data.Repositories.Base;
using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Repositories {
    public class ReturningRequestRepository : GenericRepository<ReturningRequest>, IReturningRequestRepository {
        public ReturningRequestRepository(AssetManagementDbContext context) : base(context) {
        }
    }
}
