using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Dtos.UserDtos.Requests
{
    public class DisableUserRequest
    {
        public required string UserId { get; set; }
    }
}
