using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;

namespace AssetManagement.Application.Services.Implementations {
    public class ReturningRequestService : IReturningRequestService {
        private readonly IUnitOfWork _unitOfWork;

        public ReturningRequestService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }
    }
}
