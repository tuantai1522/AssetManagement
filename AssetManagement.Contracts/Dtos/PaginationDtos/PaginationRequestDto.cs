namespace AssetManagement.Contracts.Dtos.PaginationDtos;
public class PaginationRequestDto
{
    public int pageNumber { get; set; } = 1;
    public int pageSize { get; set; } = 10;
}
