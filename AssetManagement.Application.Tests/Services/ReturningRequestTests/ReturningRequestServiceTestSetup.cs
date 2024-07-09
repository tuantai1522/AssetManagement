using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;

namespace AssetManagement.Application.Tests.Services.ReturningRequestTests {
    public class ReturningRequestServiceTestSetup : SetupTest {

        protected readonly IReturningRequestService _service;
        protected static List<AppUser> _users;
        protected static List<Asset> _assets;
        protected static List<Assignment> _assignments;
        protected static List<ReturningRequest> _returningRequests;
        public ReturningRequestServiceTestSetup() : base() {
            _service = new ReturningRequestService(_unitOfWorkMock.Object, _userManagerMock.Object, _currentUserMock.Object);
            Setup();
        }

        #region Set up 
        private static void Setup() {
            _users = new List<AppUser>()
             {
                new AppUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "binhnv",
                        Location = "HCM",
                        IsDisabled = false
                    },
                new AppUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "tridm",
                        Location = "HCM",
                        IsDisabled = false
                    },
                new AppUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "huongdt",
                        Location = "HCM",
                        IsDisabled = false
                    },
                new AppUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "longnd",
                        Location = "HCM",
                        IsDisabled = false
                    },
                new AppUser
                    {
                        Id = Guid.NewGuid(),
                        UserName = "thientd",
                        Location = "HCM",
                        IsDisabled = false
                    }
             };

            _assets = new List<Asset>() {
                new Asset
                    {
                        AssetCode = "PC00001",
                        Name = "Personal computer",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "PC00002",
                        Name = "Laptop",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "PC00003",
                        Name = "Desktop",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "PR00001",
                        Name = "Printer",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "SC00001",
                        Name = "Scanner",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "MO00001",
                        Name = "Monitor",
                        Location = "HCM"
                    },
                new Asset
                {
                    AssetCode = "KB00001",
                    Name = "Keyboard",
                    Location = "HCM"
                },
                new Asset
                    {
                        AssetCode = "MS00001",
                        Name = "Mouse",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "HD00001",
                        Name = "External Hard Drive",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "SV00001",
                        Name = "Server",
                        Location = "HCM"
                    },
                new Asset
                    {
                        AssetCode = "NW00001",
                        Name = "Network Switch",
                        Location = "HCM"
                    }
            };

            _assignments = new List<Assignment> {
                new Assignment
                {
                    Id = new Guid("82096630-505d-4a3d-b6de-3aeb3d18fdb6"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 1",
                    State = AssignmentState.WaitingForAcceptance,
                    AssignedDate = new DateTime(2023, 6, 1),
                    LastUpdated = new DateTime(2023, 6, 1),
                    AssignedToUser = _users[1],
                    AssignedByUser = _users[0],
                    Asset = (Asset)_assets[1]
                },
                new Assignment
                {
                    Id = new Guid("3a195876-191d-439e-a389-d920f1e68db2"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 2",
                    State = AssignmentState.Accepted,
                    AssignedDate = new DateTime(2023, 6, 2),
                    LastUpdated = new DateTime(2023, 6, 2),
                    AssignedToUser = _users[2],
                    AssignedByUser = _users[3],
                    Asset = (Asset)_assets[2]
                },
                new Assignment
                {
                    Id = new Guid("e84bdb67-b5dc-42de-9805-8dd0b874f14a"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 3",
                    State = AssignmentState.WaitingForAcceptance,
                    AssignedDate = new DateTime(2023, 6, 3),
                    LastUpdated = new DateTime(2023, 6, 3),
                    AssignedToUser = _users[4],
                    AssignedByUser = _users[1],
                    Asset = (Asset)_assets[3]
                },
                new Assignment
                {
                    Id = new Guid("953e5b82-3ccf-446f-a146-cb23b62bb73a"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 4",
                    State = AssignmentState.Accepted,
                    AssignedDate = new DateTime(2023, 6, 4),
                    LastUpdated = new DateTime(2023, 6, 4),
                    AssignedToUser = _users[3],
                    AssignedByUser = _users[1],
                    Asset = (Asset)_assets[4]
                },
                new Assignment
                {
                    Id = new Guid("ae83a472-3bbc-4f74-a4fd-87a166a632d4"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 5",
                    State = AssignmentState.Declined,
                    AssignedDate = new DateTime(2023, 6, 5),
                    LastUpdated = new DateTime(2023, 6, 5),
                    AssignedToUser = _users[2],
                    AssignedByUser = _users[0],
                    Asset = (Asset)_assets[5]
                },
                new Assignment
                {
                    Id = new Guid("0405d4f8-c1b7-427d-8810-3db5b074f4a4"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 6",
                    State = AssignmentState.Accepted,
                    AssignedDate = new DateTime(2023, 6, 6),
                    LastUpdated = new DateTime(2023, 6, 6),
                    AssignedToUser = _users[0],
                    AssignedByUser = _users[1],
                    Asset = (Asset)_assets[6]
                },
                new Assignment
                {
                    Id = new Guid("57de5e0c-4d67-4d81-b9b1-315f6d091752"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 7",
                    State = AssignmentState.Accepted,
                    AssignedDate = new DateTime(2023, 6, 7),
                    LastUpdated = new DateTime(2023, 6, 7),
                    AssignedToUser = _users[2],
                    AssignedByUser = _users[3],
                    Asset = (Asset)_assets[7]
                },
                new Assignment
                {
                    Id = new Guid("9393462e-1478-4aed-8e99-cae595d84212"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 8",
                    State = AssignmentState.Accepted,
                    AssignedDate = new DateTime(2023, 6, 8),
                    LastUpdated = new DateTime(2023, 6, 8),
                    AssignedToUser = _users[4],
                    AssignedByUser = _users[1],
                    Asset = (Asset)_assets[8]
                },
                new Assignment
                {
                    Id = new Guid("4ccb53df-c6ac-4204-b7b8-6597f1a694b6"),
                    AssetId = Guid.NewGuid(),
                    AssignedToId = Guid.NewGuid(),
                    AssignedById = Guid.NewGuid(),
                    Note = "Assignment 9",
                    State = AssignmentState.Accepted,
                    AssignedDate = new DateTime(2023, 6, 9),
                    LastUpdated = new DateTime(2023, 6, 9),
                    AssignedToUser = _users[4],
                    AssignedByUser = _users[1],
                    Asset = (Asset)_assets[9]
                }
            };

            _returningRequests = new List<ReturningRequest>()
            {
                new ReturningRequest
                {
                    Id = new Guid("77bb2f45-1187-4924-b8ff-00f7bc42fef7"),
                    Assignment = _assignments[0],
                    AssignmentId = _assignments[0].Id,
                    RequestedByUserId = _users[0].Id,
                    RequestedByUser = _users[0],
                    AcceptedByUser = _users[3],
                    AcceptedByUserId = _users[3].Id,
                    State = ReturningRequestState.Completed,
                    ReturnedDate = new DateTime(2024, 7, 7)
                },
                new ReturningRequest
                {
                    Id = new Guid("b998ae03-f261-4957-b597-07a5b6db3ad1"),
                    Assignment = _assignments[1],
                    AssignmentId = _assignments[1].Id,
                    RequestedByUserId = _users[1].Id,
                    RequestedByUser = _users[1],
                    AcceptedByUser = _users[3],
                    AcceptedByUserId = _users[3].Id,
                    State = ReturningRequestState.Completed,
                    ReturnedDate = new DateTime(2024, 7, 8)
                },
                new ReturningRequest
                {
                    Id = new Guid("345ce54d-1b11-4aca-ab35-2ab1fe3858a3"),
                    Assignment = _assignments[2],
                    AssignmentId = _assignments[2].Id,
                    RequestedByUserId = _users[1].Id,
                    RequestedByUser = _users[1],
                    State = ReturningRequestState.WaitingForReturning,
                },
                new ReturningRequest
                {
                    Id = new Guid("fd14ce2a-c4b4-4e94-bd46-5a26dbcb89dc"),
                    Assignment = _assignments[3],
                    AssignmentId = _assignments[3].Id,
                    AcceptedByUser = _users[4],
                    AcceptedByUserId = _users[4].Id,
                    RequestedByUserId = _users[2].Id,
                    RequestedByUser = _users[2],
                    State = ReturningRequestState.Completed,
                    ReturnedDate = new DateTime(2024, 7, 9)
                },

                new ReturningRequest
                {
                    Id = new Guid("cae4e9aa-f91a-4bb0-9e7d-f9c22bfe2eaf"),
                    Assignment = _assignments[4],
                    AssignmentId = _assignments[4].Id,
                    RequestedByUserId = _users[1].Id,
                    RequestedByUser = _users[1],
                    State = ReturningRequestState.WaitingForReturning,
                },
                new ReturningRequest
                {
                    Id = new Guid("c57d03b0-c899-4027-bee1-80a367917ccc"),
                    Assignment = _assignments[5],
                    AssignmentId = _assignments[5].Id,
                    RequestedByUserId = _users[4].Id,
                    RequestedByUser = _users[4],
                    State = ReturningRequestState.WaitingForReturning,
                },
                new ReturningRequest
                {
                    Id = new Guid("4c082762-48da-402a-a26b-15f1025e5fab"),
                    Assignment = _assignments[6],
                    AssignmentId = _assignments[6].Id,
                    AcceptedByUser = _users[2],
                    AcceptedByUserId = _users[2].Id,
                    RequestedByUserId = _users[4].Id,
                    RequestedByUser = _users[4],
                    State = ReturningRequestState.Completed,
                    ReturnedDate = new DateTime(2024, 7, 8)
                },
            };
        }
        #endregion
    }
}
