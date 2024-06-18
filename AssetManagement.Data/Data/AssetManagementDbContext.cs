using AssetManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace AssetManagement.Data.Data
{
    public class AssetManagementDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public AssetManagementDbContext(DbContextOptions<AssetManagementDbContext> options) : base(options)
        {
        }

        public AssetManagementDbContext() : base(new DbContextOptions<AssetManagementDbContext>()) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}