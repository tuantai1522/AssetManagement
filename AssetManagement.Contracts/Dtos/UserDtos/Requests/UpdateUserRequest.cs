using AssetManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Dtos.UserDtos.Requests
{
    public class UpdateUserRequest
	{
		[Required]
		public DateTime JoinedDate { get; set; }
		[Required]
		public DateTime DateOfBirth { get; set; }
		[Required]
		public required string Gender { get; set; }
		[Required]
		public required string Type { get; set; }
	}
}
