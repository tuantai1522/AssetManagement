using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Disable([FromBody] UserDisableRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
