using AssetManagement.Data.Interfaces.Base;
using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Interfaces {
    public interface IReturningRequestRepository : IGenericRepository<ReturningRequest> {
		public Task<ReturningRequest?> GetRequestByIdAsync(Guid id);
	}
}
