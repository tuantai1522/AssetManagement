using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Data.SeedDatabase
{
    public class AssetSeeder
    {
        public static void SeedAssets(ModelBuilder modelBuilder)
        {
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    Id = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop",
                    Prefix = "LA"
                },
                new Category
                {
                    Id = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor",
                    Prefix = "MO"
                },
                new Category
                {
                    Id = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer",
                    Prefix = "PC"
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            List<Asset> assets = new List<Asset>()
            {
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000001",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop HP ProBook 450 G1",
                    Specification = "Core i5, 8GB RAM, 750 GB HDD, Window 8",
                    InstalledDate = new DateTime(2008, 6,1,7,47,0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000001",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor Dell UltraSharp",
                    Specification = "24 inch, Full HD",
                    InstalledDate = new DateTime(2010, 7, 15, 10, 30, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000001",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Dell Inspiron",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 10",
                    InstalledDate = new DateTime(2012, 5, 20, 14, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000002",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Dell XPS 13",
                    Specification = "Core i7, 16GB RAM, 512GB SSD, Windows 10",
                    InstalledDate = new DateTime(2015, 3, 10, 8, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000002",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor Samsung Curved",
                    Specification = "27 inch, QHD",
                    InstalledDate = new DateTime(2018, 1, 5, 9, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000002",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer HP EliteDesk",
                    Specification = "Core i5, 8GB RAM, 512GB SSD, Windows 10",
                    InstalledDate = new DateTime(2016, 6, 25, 11, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000003",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Lenovo ThinkPad",
                    Specification = "Core i5, 8GB RAM, 256GB SSD, Windows 10",
                    InstalledDate = new DateTime(2019, 9, 1, 12, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000003",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor LG UltraWide",
                    Specification = "34 inch, WQHD",
                    InstalledDate = new DateTime(2020, 12, 15, 13, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000003",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Acer Aspire",
                    Specification = "Core i3, 4GB RAM, 1TB HDD, Windows 8",
                    InstalledDate = new DateTime(2013, 4, 15, 10, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000004",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Asus ZenBook",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2021, 7, 10, 9, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000005",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop HP Envy",
                    Specification = "Core i7, 16GB RAM, 512GB SSD, Windows 11",
                    InstalledDate = new DateTime(2022, 1, 15, 10, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000004",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor ASUS ProArt",
                    Specification = "32 inch, 4K UHD",
                    InstalledDate = new DateTime(2022, 2, 10, 11, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000004",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Lenovo IdeaCentre",
                    Specification = "Core i5, 8GB RAM, 1TB HDD, Windows 10",
                    InstalledDate = new DateTime(2022, 3, 5, 9, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000006",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Apple MacBook Air",
                    Specification = "M1, 8GB RAM, 256GB SSD, macOS",
                    InstalledDate = new DateTime(2022, 4, 1, 8, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000005",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor BenQ DesignVue",
                    Specification = "27 inch, 4K UHD",
                    InstalledDate = new DateTime(2022, 5, 1, 12, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000005",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer MSI Trident",
                    Specification = "Core i9, 32GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2022, 6, 1, 14, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000007",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Microsoft Surface",
                    Specification = "Core i7, 16GB RAM, 512GB SSD, Windows 11",
                    InstalledDate = new DateTime(2022, 7, 15, 10, 0, 0),
                    State = AssetState.Recycled,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000006",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor ViewSonic VP",
                    Specification = "27 inch, WQHD",
                    InstalledDate = new DateTime(2022, 8, 1, 11, 0, 0),
                    State = AssetState.Recycled,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000006",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Dell G5",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2022, 9, 1, 10, 0, 0),
                    State = AssetState.Recycled,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                 new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000008",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Dell Latitude",
                    Specification = "Core i5, 8GB RAM, 256GB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 1, 10, 10, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000007",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor Acer Predator",
                    Specification = "32 inch, QHD",
                    InstalledDate = new DateTime(2023, 2, 15, 11, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000007",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Apple iMac",
                    Specification = "M1, 16GB RAM, 512GB SSD, macOS",
                    InstalledDate = new DateTime(2023, 3, 20, 9, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000009",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Acer Swift",
                    Specification = "Core i5, 8GB RAM, 512GB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 4, 5, 8, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000008",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor Philips Brilliance",
                    Specification = "34 inch, 4K UHD",
                    InstalledDate = new DateTime(2023, 5, 10, 12, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000008",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer ASUS ROG",
                    Specification = "Core i9, 32GB RAM, 2TB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 6, 15, 14, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000010",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop HP Spectre",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 7, 1, 10, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000009",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor HP Omen",
                    Specification = "32 inch, QHD",
                    InstalledDate = new DateTime(2023, 8, 15, 11, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000009",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer HP Pavilion",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 9, 1, 10, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000011",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop ASUS VivoBook",
                    Specification = "Core i5, 8GB RAM, 512GB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 10, 5, 8, 0, 0),
                    State = AssetState.Recycled,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000010",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor Dell Gaming",
                    Specification = "32 inch, QHD",
                    InstalledDate = new DateTime(2023, 11, 10, 12, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000010",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer HP Envy",
                    Specification = "Core i9, 32GB RAM, 2TB SSD, Windows 11",
                    InstalledDate = new DateTime(2023, 12, 15, 14, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000012",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Lenovo Yoga",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2024, 1, 5, 8, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000011",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor Samsung Odyssey",
                    Specification = "49 inch, QHD",
                    InstalledDate = new DateTime(2024, 2, 10, 11, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000011",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Dell Optiplex",
                    Specification = "Core i7, 16GB RAM, 512GB SSD, Windows 11",
                    InstalledDate = new DateTime(2024, 3, 20, 9, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000013",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Apple MacBook Pro",
                    Specification = "M1 Pro, 16GB RAM, 1TB SSD, macOS",
                    InstalledDate = new DateTime(2024, 4, 5, 8, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000012",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor LG UltraGear",
                    Specification = "32 inch, QHD",
                    InstalledDate = new DateTime(2024, 5, 10, 12, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000012",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer ASUS VivoPC",
                    Specification = "Core i5, 8GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2024, 6, 15, 14, 0, 0),
                    State = AssetState.NotAvailable,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000014",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop Dell Inspiron",
                    Specification = "Core i5, 8GB RAM, 256GB SSD, Windows 11",
                    InstalledDate = new DateTime(2024, 7, 1, 10, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000013",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor ViewSonic Elite",
                    Specification = "32 inch, QHD",
                    InstalledDate = new DateTime(2024, 8, 15, 11, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000013",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Apple Mac Mini",
                    Specification = "M1, 8GB RAM, 256GB SSD, macOS",
                    InstalledDate = new DateTime(2024, 9, 1, 10, 0, 0),
                    State = AssetState.WaitingForRecycling,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "LA000015",
                    CategoryId = new Guid("03ae1142-dd28-456d-ab7c-95200ac98817"),
                    Name = "Laptop ASUS ZenBook Duo",
                    Specification = "Core i7, 16GB RAM, 1TB SSD, Windows 11",
                    InstalledDate = new DateTime(2024, 10, 5, 8, 0, 0),
                    State = AssetState.Available,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "MO000014",
                    CategoryId = new Guid("cbe57beb-a25c-4a05-8316-a9a3878ecf06"),
                    Name = "Monitor ASUS TUF",
                    Specification = "32 inch, QHD",
                    InstalledDate = new DateTime(2024, 11, 10, 12, 0, 0),
                    State = AssetState.Recycled,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HN"
                },
                new Asset
                {
                    Id = Guid.NewGuid(),
                    AssetCode = "PC000014",
                    CategoryId = new Guid("b26a3787-72ae-47e4-9d11-6e74d721d2bb"),
                    Name = "Personal Computer Lenovo ThinkCentre",
                    Specification = "Core i7, 16GB RAM, 512GB SSD, Windows 11",
                    InstalledDate = new DateTime(2024, 12, 15, 14, 0, 0),
                    State = AssetState.Recycled,
                    CreatedAt = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Location = "HCM"
                }
            };
            modelBuilder.Entity<Asset>().HasData(assets);
        }
    }
}
