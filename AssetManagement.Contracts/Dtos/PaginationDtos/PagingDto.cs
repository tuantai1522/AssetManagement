namespace AssetManagement.Contracts.Dtos.PaginationDtos;
public class PagingDto<T> where T : class
{
    public int TotalItemCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }

    public List<T> Data { get; set; } = [];
}

