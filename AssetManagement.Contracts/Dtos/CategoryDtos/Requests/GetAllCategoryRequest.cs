using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Dtos.CategoryDtos.Requests
{
    public class GetAllCategoryRequest
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 50;
    }
}
