using AssetManagement.Data.Data.SeedDatabase;
using AssetManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AssetManagement.Data.Data
{
    public class AssetManagementDbContext : IdentityDbContext<AppUser, Role, Guid>
    {
        public AssetManagementDbContext(DbContextOptions<AssetManagementDbContext> options) : base(options)
        {
        }

        public AssetManagementDbContext() : base(new DbContextOptions<AssetManagementDbContext>()) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // UserSeeder.SeedUsers(builder);
            // AssetSeeder.SeedAssets(builder);
            AssignmentSeeder.SeedAssignments(builder);
        }
    }
}