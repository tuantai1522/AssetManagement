using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Data.SeedDatabase
{
    public class AssignmentSeeder
    {
        public static void SeedAssignments(ModelBuilder modelBuilder)
        {
            List<Assignment> assignments =
            [
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("797D40D3-217A-4AD9-962B-076A98EBCACB"),
                    AssignedToId = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    AssignedById = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    Note = "Assignment 1",
                    State = AssignmentState.WaitingForAcceptance,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("81436C8D-4090-4ABF-A926-14D061F1F9C9"),
                    AssignedToId = new Guid("AFA27F12-EE0B-4A82-B30B-507A680CB9CF"),
                    AssignedById = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    Note = "Assignment 2",
                    State = AssignmentState.Accepted,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("48E50B2E-2B0A-44CB-A054-1DC044EF0677"),
                    AssignedToId = new Guid("AFA27F12-EE0B-4A82-B30B-507A680CB9CF"),
                    AssignedById = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    Note = "Assignment 3",
                    State = AssignmentState.WaitingForAcceptance,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("9A7E2A23-23B6-4172-946A-28470034253B"),
                    AssignedToId = new Guid("151E3A0F-5CD2-48AD-AE50-783614F5D4FF"),
                    AssignedById = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    Note = "Assignment 4",
                    State = AssignmentState.Accepted,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("503C3EB7-3A05-4123-8C69-3011BEE3D553"),
                    AssignedToId = new Guid("2450BC08-8B39-41CF-90E9-7B10510C557E"),
                    AssignedById = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    Note = "Assignment 5",
                    State = AssignmentState.WaitingForAcceptance,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("F673F337-C449-4FF1-97CD-366B79CF3A63"),
                    AssignedToId = new Guid("06F00EB0-B413-4096-AC54-8A501D96D3DA"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 6",
                    State = AssignmentState.Declined,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("A91D8139-49FF-43F2-A9C1-379142B3C056"),
                    AssignedToId = new Guid("256A9CEF-7479-4563-A104-8B310E16FFE0"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 7",
                    State = AssignmentState.WaitingForAcceptance,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("07ED57D0-9745-43E0-A40E-39A29C957C1B"),
                    AssignedToId = new Guid("EDE0C1CD-5D7E-422C-A787-8F473C45123B"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 8",
                    State = AssignmentState.Accepted,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("48E50B2E-2B0A-44CB-A054-1DC044EF0677"),
                    AssignedToId = new Guid("49C2B516-B12E-4DD8-AE2B-9027446F4B77"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 9",
                    State = AssignmentState.Declined,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                },
                new Assignment
                {
                    Id = Guid.NewGuid(),
                    AssetId = new Guid("9A7E2A23-23B6-4172-946A-28470034253B"),
                    AssignedToId = new Guid("48BC2207-EC50-455D-99E4-990995F809E0"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 10",
                    State = AssignmentState.Declined,
                    AssignedDate = DateTime.UtcNow,
                    LastUpdated = DateTime.UtcNow
                }
            ];

            modelBuilder.Entity<Assignment>().HasData(assignments);
        }
    }
}