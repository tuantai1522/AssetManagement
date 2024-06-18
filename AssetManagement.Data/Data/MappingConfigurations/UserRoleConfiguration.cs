using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.Data.MappingConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid>()
                {
                    RoleId = new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"),
                    UserId = new Guid("ed44d5cb-19b2-4fc8-b292-78faf498995b"),
                });
        }
    }
}
