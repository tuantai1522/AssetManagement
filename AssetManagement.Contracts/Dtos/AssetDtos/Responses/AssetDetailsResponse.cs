using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Dtos.AssetDtos.Responses
{
    public class AssetDetailsResponse
    {
        public string? AssetCode { get; set; }
        public string? AssetName { get; set; }
        public string? CategoryName { get; set; }
        public DateTime InstalledDate { get; set; }
        public string? State { get; set; }
        public string? Location { get; set; }
        public string? Specification { get; set; }
    }
}
