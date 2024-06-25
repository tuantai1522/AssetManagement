using AssetManagement.Domain.Constants;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace AssetManagement.Data.Data.SeedDatabase;
public class UserSeeder
{
    private static readonly List<string> firstNames = new List<string>
    {
        "John", "Emma", "Michael", "Olivia", "William",
        "Ava", "James", "Sophia", "Benjamin", "Isabella",
        "Elijah", "Mia", "Daniel", "Charlotte", "David",
        "Amelia", "Alexander", "Harper", "Joseph", "Evelyn"
    };

    private static readonly List<string> lastNames = new List<string>
    {
        "Smith", "Johnson", "Williams", "Brown", "Jones",
        "Miller", "Davis", "Garcia", "Rodriguez", "Martinez",
        "Wilson", "Anderson", "Taylor", "Thomas", "Jackson",
        "White", "Harris", "Clark", "Lewis", "Young"
    };

    private static List<string> storeUsernames = new List<string>();

    public static void SeedUsers(ModelBuilder modelBuilder)
    {
        var random = new Random();
        var passwordHasher = new PasswordHasher<AppUser>();

        // Generate default admins
        var defaultAdmins = DefaultAdmins();
        foreach (var admin in defaultAdmins)
        {
            modelBuilder.Entity<AppUser>().HasData(admin);

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = admin.Id,
                RoleId = new Guid(RoleConstant.AdminRoleId)
            });
        }
        // Generate default staffs
        var defaultStaffs = DefaultStaffs();
        foreach (var staffDefault in defaultStaffs)
        {
            modelBuilder.Entity<AppUser>().HasData(staffDefault);

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                UserId = staffDefault.Id,
                RoleId = new Guid(RoleConstant.StaffRoleId)
            });
        }

        // Generate random users
        var startIndex = defaultAdmins.Count + defaultStaffs.Count + 1;
        int numOfAdmins = 10;
        int numOfStaffs = 50;
        for (int i = startIndex; i < (numOfAdmins + numOfStaffs + startIndex); i++)
        {
            var firstName = firstNames[random.Next(firstNames.Count)];
            var lastName = lastNames[random.Next(lastNames.Count)];
            var username = GenerateUsername(firstName, lastName);
            var email = string.Concat(username, "@gmail.com");
            var user = new AppUser
            {
                Id = Guid.NewGuid(),
                UserName = username,
                NormalizedUserName = username.ToUpper(),
                Email = email,
                NormalizedEmail = email.ToUpper(),
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName,
                Gender = ((Gender)random.Next(1, 3)).ToString(),
                Location = ((Location)random.Next(1, 3)).ToString(),
                IsPasswordChanged = false,
                StaffCode = string.Concat("SD", i.ToString().PadLeft(4, '0')),
                IsDisabled = false,
                DateOfBirth = GetRandomBirthday(),
                JoinedDate = DateTime.Now,
                CreatedDateTime = DateTime.UtcNow,
                LastUpdatedDateTime = DateTime.UtcNow,
            };
            //Add admins
            if (numOfAdmins > 0)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, "Admin@123");

                modelBuilder.Entity<AppUser>().HasData(user);

                modelBuilder.Entity<UserRole>().HasData(new UserRole
                {
                    UserId = user.Id,
                    RoleId = new Guid(RoleConstant.AdminRoleId)
                });
                numOfAdmins--;
            }
            //Add staffs
            else if (numOfStaffs > 0)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, "User@123");

                modelBuilder.Entity<AppUser>().HasData(user);

                modelBuilder.Entity<UserRole>().HasData(new UserRole
                {
                    UserId = user.Id,
                    RoleId = new Guid(RoleConstant.StaffRoleId)
                });
                numOfStaffs--;
            }
        }
    }

    private static DateTime GetRandomBirthday()
    {
        DateTime now = DateTime.Now;
        Random random = new Random();

        int minDaysAgo = 365 * 18;
        int maxDaysAgo = 365 * 30;
        int randomDays = random.Next(minDaysAgo, maxDaysAgo);

        DateTime randomDateTime = now.AddDays(-randomDays);

        return randomDateTime;
    }

    private static string GenerateUsername(string firstName, string lastName)
    {
        var userName = firstName.ToLower() + string.Join("", lastName.Split([' ']).Select(word => word.First())).ToLower();

        var firstSimilarUsername = storeUsernames.Where(u => u.Contains(userName)).OrderByDescending(u => u).FirstOrDefault();
        if (firstSimilarUsername != null)
        {
            string numberStr = Regex.Match(firstSimilarUsername, @"\d+").Value;
            if (int.TryParse(numberStr, out int number) && number > 0)
            {
                userName += (number + 1).ToString();
            }
            else
            {
                userName += "1";
            }
        }
        storeUsernames.Add(userName);
        return userName;
    }

    private static List<AppUser> DefaultAdmins()
    {
        var passwordHasher = new PasswordHasher<AppUser>();
        List<AppUser> admins = new List<AppUser>();

        var adminHcm = new AppUser()
        {
            Id = Guid.NewGuid(),
            UserName = $"adminhcm",
            NormalizedUserName = $"ADMINHCM",
            Email = $"adminhcm@gmail.com",
            NormalizedEmail = $"ADMINHCM@GMAIL.COM",
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            FirstName = $"Admin",
            LastName = $"HCM",
            Gender = "Male",
            Location = "HCM",
            IsPasswordChanged = false,
            StaffCode = "SD0001",
            IsDisabled = false,
            DateOfBirth = GetRandomBirthday(),
            JoinedDate = DateTime.Now,
            CreatedDateTime = DateTime.UtcNow,
            LastUpdatedDateTime = DateTime.UtcNow,
        };
        adminHcm.PasswordHash = passwordHasher.HashPassword(adminHcm, "Admin@123");
        var adminHn = new AppUser()
        {
            Id = Guid.NewGuid(),
            UserName = $"adminhn",
            NormalizedUserName = $"ADMINHN",
            Email = $"adminhn@gmail.com",
            NormalizedEmail = $"ADMINHN@GMAIL.COM",
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            FirstName = $"Admin",
            LastName = $"HN",
            Gender = "Male",
            Location = "HN",
            IsPasswordChanged = false,
            StaffCode = "SD0002",
            IsDisabled = false,
            DateOfBirth = GetRandomBirthday(),
            JoinedDate = DateTime.Now,
            CreatedDateTime = DateTime.UtcNow,
            LastUpdatedDateTime = DateTime.UtcNow,
        };
        adminHn.PasswordHash = passwordHasher.HashPassword(adminHn, "Admin@123");
        admins.Add(adminHn);
        admins.Add(adminHcm);

        return admins;
    }

    private static List<AppUser> DefaultStaffs()
    {
        var passwordHasher = new PasswordHasher<AppUser>();
        List<AppUser> staffs = new List<AppUser>();

        var staffHcm = new AppUser()
        {
            Id = Guid.NewGuid(),
            UserName = $"staffhcm",
            NormalizedUserName = $"STAFFHCM",
            Email = $"staffhcm@gmail.com",
            NormalizedEmail = $"STAFFHCM@GMAIL.COM",
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            FirstName = $"Staff",
            LastName = $"HCM",
            Gender = "Male",
            Location = "HCM",
            IsPasswordChanged = false,
            StaffCode = "SD0003",
            IsDisabled = false,
            DateOfBirth = GetRandomBirthday(),
            JoinedDate = DateTime.Now,
            CreatedDateTime = DateTime.UtcNow,
            LastUpdatedDateTime = DateTime.UtcNow,
        };
        staffHcm.PasswordHash = passwordHasher.HashPassword(staffHcm, "Staff@123");
        var staffHn = new AppUser()
        {
            Id = Guid.NewGuid(),
            UserName = $"staffhn",
            NormalizedUserName = $"STAFFHN",
            Email = $"staffhn@gmail.com",
            NormalizedEmail = $"STAFFHN@GMAIL.COM",
            LockoutEnabled = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            FirstName = $"Staff",
            LastName = $"HN",
            Gender = "Male",
            Location = "HN",
            IsPasswordChanged = false,
            StaffCode = "SD0004",
            IsDisabled = false,
            DateOfBirth = GetRandomBirthday(),
            JoinedDate = DateTime.Now,
            CreatedDateTime = DateTime.UtcNow,
            LastUpdatedDateTime = DateTime.UtcNow,
        };
        staffHn.PasswordHash = passwordHasher.HashPassword(staffHn, "Staff@123");
        staffs.Add(staffHn);
        staffs.Add(staffHcm);

        return staffs;
    }
}
