using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetManagement.Data.Data.MappingConfigurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            #region define index

            builder.HasIndex(user => user.StaffCode)
                .IsUnique(true);

            builder.HasIndex(user => user.UserName)
                .IsUnique(true);

            builder.HasIndex(user => new
            {
                user.FirstName,
                user.LastName
            });

            #endregion
        }
    }
}
