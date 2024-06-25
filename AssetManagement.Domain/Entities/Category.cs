namespace AssetManagement.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Prefix { get; set; }
        public IEnumerable<Asset> Assets { get; set; }
    }
}
