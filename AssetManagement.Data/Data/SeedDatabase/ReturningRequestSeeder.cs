using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Data.SeedDatabase {
    internal class ReturningRequestSeeder {
        public static void SeedReturningRequest(ModelBuilder modelBuilder) {
            List<Assignment> assignmentData = [
                new Assignment {
                    Id = new Guid("ab64f62d-71a0-4520-9522-2bbbebbc1c7b"),
                    AssetId = new Guid("81436C8D-4090-4ABF-A926-14D061F1F9C9"),
                    AssignedToId = new Guid("48BC2207-EC50-455D-99E4-990995F809E0"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 11",
                    State = AssignmentState.Returned,
                    AssignedDate = new DateTime(2024,7,7),
                    LastUpdated = DateTime.Now
                },
                new Assignment {
                    Id = new Guid("1f01cf21-4609-41d8-be82-446f42f6dd68"),
                    AssetId = new Guid("F673F337-C449-4FF1-97CD-366B79CF3A63"),
                    AssignedToId = new Guid("EDE0C1CD-5D7E-422C-A787-8F473C45123B"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 12",
                    State = AssignmentState.Returned,
                    AssignedDate = new DateTime(2024,7,8),
                    LastUpdated = DateTime.Now
                },
                new Assignment
                {
                    Id = new Guid("26c42587-dd3c-4546-a1e5-e286ca0bc2a2"),
                    AssetId = new Guid("F0DFF85D-6CC7-496B-8437-40B50298E62C"),
                    AssignedToId = new Guid("256A9CEF-7479-4563-A104-8B310E16FFE0"),
                    AssignedById = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    Note = "Assignment 13",
                    State = AssignmentState.Returned,
                    AssignedDate = new DateTime(2024,7,5),
                    LastUpdated = DateTime.Now
                },
                new Assignment
                {
                    Id = new Guid("a50232d9-c3da-44d6-81a1-da151617d805"),
                    AssetId = new Guid("0EAB77A8-ED89-4483-9D98-6CCAFA74D450"),
                    AssignedToId = new Guid("2450BC08-8B39-41CF-90E9-7B10510C557E"),
                    AssignedById = new Guid("2C484448-B14E-46F3-957E-A8719F14BBD6"),
                    Note = "Assignment 14",
                    State = AssignmentState.Returned,
                    AssignedDate = new DateTime(2024,7,9),
                    LastUpdated = DateTime.Now
                },
            ];

            List<ReturningRequest> returningRequestData =
            [
                new ReturningRequest
                {
                    Id = Guid.NewGuid(),
                    AssignmentId = new Guid("ab64f62d-71a0-4520-9522-2bbbebbc1c7b"),
                    RequestedByUserId = new Guid("59339CDA-7D6D-4CBF-833C-367D7DB965E1"),
                    AcceptedByUserId = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    ReturnedDate = DateTime.Now,
                    State = ReturningRequestState.Completed
                },
                new ReturningRequest
                {
                    Id = Guid.NewGuid(),
                    AssignmentId = new Guid("1f01cf21-4609-41d8-be82-446f42f6dd68"),
                    RequestedByUserId = new Guid("5A1C0199-F674-408D-84FE-37E2A890D93B"),
                    AcceptedByUserId = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    ReturnedDate = DateTime.Now,
                    State = ReturningRequestState.Completed
                },
                new ReturningRequest
                {
                    Id = Guid.NewGuid(),
                    AssignmentId = new Guid("26c42587-dd3c-4546-a1e5-e286ca0bc2a2"),
                    RequestedByUserId = new Guid("60C17FCB-178E-4181-AD50-3690524F5190"),
                    AcceptedByUserId = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    ReturnedDate = DateTime.Now,
                    State = ReturningRequestState.Completed
                },
                new ReturningRequest
                {
                    Id = Guid.NewGuid(),
                    AssignmentId = new Guid("a50232d9-c3da-44d6-81a1-da151617d805"),
                    RequestedByUserId = new Guid("06F00EB0-B413-4096-AC54-8A501D96D3DA"),
                    AcceptedByUserId = new Guid("4C196276-54F0-48AE-ACC9-ABEB0CB598F5"),
                    ReturnedDate = DateTime.Now,
                    State = ReturningRequestState.Completed
                },
            ];

            modelBuilder.Entity<Assignment>().HasData(assignmentData);
            modelBuilder.Entity<ReturningRequest>().HasData(returningRequestData);
        }
    }
}
