using AssetManagement.Domain.Constants;
using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.Data.MappingConfigurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = new Guid(RoleConstant.AdminRoleId),
                    Name = RoleConstant.AdminRole,
                    NormalizedName = RoleConstant.AdminRole.ToUpper()
                },
                new Role
                {
                    Id = new Guid(RoleConstant.StaffRoleId),
                    Name = RoleConstant.StaffRole,
                    NormalizedName = RoleConstant.StaffRole.ToUpper()
                });
        }
    }
}
