using AssetManagement.Domain.Constants;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Data.SeedDatabase;
public class UserSeeder
{
    public static void SeedUsers(ModelBuilder modelBuilder)
    {
        var random = new Random();
        var passwordHasher = new PasswordHasher<AppUser>();
        int numOfAdmins = 10;
        // Generate 10 admin
        for (int i = 2; i <= numOfAdmins; i++)
        {
            var admin = new AppUser
            {
                Id = Guid.NewGuid(),
                UserName = $"admin{i}",
                NormalizedUserName = $"ADMIN{i}",
                Email = $"admin{i}@gmail.com",
                NormalizedEmail = $"ADMIN{i}@GMAIL.COM",
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = $"AdminFirst{i}",
                LastName = $"AdminLast{i}",
                Gender = ((Gender)random.Next(1, 3)).ToString(),
                Location = ((Location)random.Next(1, 3)).ToString(),
                IsPasswordChanged = true,
                StaffCode = string.Concat("SD", i.ToString().PadLeft(4, '0')),
                IsDisabled = false,
                DateOfBirth = GetRandomBirthday(),
                JoinedDate = DateTime.Now,
                CreatedDateTime = DateTime.UtcNow,
                LastUpdatedDateTime = DateTime.UtcNow,
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin@123");

            modelBuilder.Entity<AppUser>().HasData(admin);

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = admin.Id,
                RoleId = new Guid(RoleConstant.AdminRoleId)
            });
        }

        // Generate 30 staffs
        int startId = numOfAdmins + 1;
        for (int i = 1; i <= 30; i++)
        {
            var user = new AppUser
            {
                Id = Guid.NewGuid(),
                UserName = $"user{i}",
                NormalizedUserName = $"USER{i}",
                Email = $"user{i}@gmail.com",
                NormalizedEmail = $"USER{i}@GMAIL.COM",
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = $"UserFirst{i}",
                LastName = $"UserLast{i}",
                Gender = ((Gender)random.Next(1, 3)).ToString(),
                Location = ((Location)random.Next(1, 3)).ToString(),
                IsPasswordChanged = true,
                StaffCode = string.Concat("SD", startId.ToString().PadLeft(4, '0')),
                IsDisabled = false,
                DateOfBirth = GetRandomBirthday(),
                JoinedDate = DateTime.Now,
                CreatedDateTime = DateTime.UtcNow,
                LastUpdatedDateTime = DateTime.UtcNow,
            };
            user.PasswordHash = passwordHasher.HashPassword(user, "User@123");

            modelBuilder.Entity<AppUser>().HasData(user);

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = user.Id,
                RoleId = new Guid(RoleConstant.StaffRoleId)
            });
            startId++;
        }
    }

    public static DateTime GetRandomBirthday()
    {
        DateTime now = DateTime.Now;
        Random random = new Random();

        int minDaysAgo = 365 * 18;
        int maxDaysAgo = 365 * 30;
        int randomDays = random.Next(minDaysAgo, maxDaysAgo);

        DateTime randomDateTime = now.AddDays(-randomDays);

        return randomDateTime;
    }
}
