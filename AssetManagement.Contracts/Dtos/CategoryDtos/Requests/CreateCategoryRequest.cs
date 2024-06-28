namespace AssetManagement.Contracts.Dtos.CategoryDtos.Requests;

public class CreateCategoryRequest
{
    public required string Name { get; set; }
    public required string Prefix { get; set; }
}

