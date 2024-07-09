using AssetManagement.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers {
    [Route("api/return-request")]
    [ApiController]
    public class ReturningRequestController : ControllerBase {

        private readonly IReturningRequestService _returningRequestService;

        public ReturningRequestController(IReturningRequestService returningRequestService) {
            _returningRequestService = returningRequestService;
        }
    }
}
