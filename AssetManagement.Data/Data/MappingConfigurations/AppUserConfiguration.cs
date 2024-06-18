using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.AspNetCore.Identity;
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

            #endregion

            #region init data 

            var passwordHasher = new PasswordHasher<AppUser>();

            var admin = new AppUser()
            {
                Id = new Guid("ed44d5cb-19b2-4fc8-b292-78faf498995b"),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "Nghĩa",
                LastName = "Đinh Trọng",
                Gender = Gender.Male.ToString(),
                Location = Location.HCM.ToString(),
                IsPasswordChanged = true,
                StaffCode = "SD0001",
                IsDisabled = false,
                CreatedDateTime = DateTime.UtcNow,
                LastUpdatedDateTime = DateTime.UtcNow
            };

            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin@123");

            builder.HasData(admin);


            #endregion
        }
    }
}
