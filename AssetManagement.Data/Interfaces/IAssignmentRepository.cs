using AssetManagement.Data.Interfaces.Base;
using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Interfaces
{
    public interface IAssignmentRepository : IGenericRepository<Assignment>
    {
		public Task<Assignment?> GetAssignmentByIdAsync(Guid id);
	}
}