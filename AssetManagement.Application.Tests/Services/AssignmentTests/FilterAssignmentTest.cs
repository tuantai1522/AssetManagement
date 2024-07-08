using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using MockQueryable.Moq;
using System.Collections;

namespace AssetManagement.Application.Tests.Services.AssignmentTests {
    public class FilterAssignmentTest : SetupAssignmentServiceTest {

        private static List<Assignment> _assignments;
        private static List<AppUser> _users;

        public FilterAssignmentTest() : base() {
            Setup();
        }

        #region setup
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

            ArrayList assets = new ArrayList() {
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

            _assignments = new List<Assignment>
{
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
        Asset = (Asset)assets[1]
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
        Asset = (Asset)assets[2]
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
        Asset = (Asset)assets[3]
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
        Asset = (Asset)assets[4]
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
        Asset = (Asset)assets[5]
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
        Asset = (Asset)assets[6]
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
        Asset = (Asset)assets[7]
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
        Asset = (Asset)assets[8]
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
        Asset = (Asset)assets[9]
    }
};
        }
        #endregion

        [Theory]
        [InlineData(1, null)]
        [InlineData(0, 6)]
        [InlineData(-1, 4)]
        [InlineData(1, 0)]
        [InlineData(1, -1)]
        [InlineData(null, 4)]
        public async Task FilterAssignmentAsync_ShouldReturnPagingDto_WithFilteredAssignments(int? pageNumber, int? pageSize) {
            // Arrange

            var filter = new FilterAssignmentRequest()
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            _currentUserMock.Setup(m => m.UserId).Returns(_users[0].Id);
            _userManagerMock.Setup(m => m.Users).Returns(_users.BuildMock);

            _unitOfWorkMock.Setup(m => m.AssignmentRepository).Returns(_assignmentRepositoryMock.Object);
            _assignmentRepositoryMock.Setup(m => m.GetQueryableSet())
                .Returns(_assignments.BuildMock);

            // Act
            var result = await _assignmentService.FilterAssignmentAsync(filter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(_assignments.Count(), result.TotalItemCount);
            Assert.Equal(5, result.Data.Count);
        }

        [Theory]
        [InlineData(SortOption.Asc, null, null, null, null, null, null, "9393462e-1478-4aed-8e99-cae595d84212")]
        [InlineData(SortOption.Desc, null, null, null, null, null, null, "4ccb53df-c6ac-4204-b7b8-6597f1a694b6")]
        [InlineData(null, SortOption.Asc, null, null, null, null, null, "3a195876-191d-439e-a389-d920f1e68db2")]
        [InlineData(null, SortOption.Desc, null, null, null, null, null, "4ccb53df-c6ac-4204-b7b8-6597f1a694b6")]
        [InlineData(null, null, SortOption.Asc, null, null, null, null, "0405d4f8-c1b7-427d-8810-3db5b074f4a4")]
        [InlineData(null, null, SortOption.Desc, null, null, null, null, "82096630-505d-4a3d-b6de-3aeb3d18fdb6")]
        [InlineData(null, null, null, SortOption.Asc, null, null, null, "82096630-505d-4a3d-b6de-3aeb3d18fdb6")]
        [InlineData(null, null, null, SortOption.Desc, null, null, null, "e84bdb67-b5dc-42de-9805-8dd0b874f14a")]
        [InlineData(null, null, null, null, SortOption.Asc, null, null, "82096630-505d-4a3d-b6de-3aeb3d18fdb6")]
        [InlineData(null, null, null, null, SortOption.Desc, null, null, "4ccb53df-c6ac-4204-b7b8-6597f1a694b6")]
        [InlineData(null, null, null, null, null, SortOption.Asc, null, "3a195876-191d-439e-a389-d920f1e68db2")]
        [InlineData(null, null, null, null, null, SortOption.Desc, null, "82096630-505d-4a3d-b6de-3aeb3d18fdb6")]
        [InlineData(null, null, null, null, null, null, SortOption.Asc, "82096630-505d-4a3d-b6de-3aeb3d18fdb6")]
        [InlineData(null, null, null, null, null, null, SortOption.Desc, "4ccb53df-c6ac-4204-b7b8-6597f1a694b6")]
        public async Task FilterAssignmentAsync_ShouldReturnCorrectSortOrder(
            SortOption? sortAssetCode,
            SortOption? sortAssetName,
            SortOption? sortAssignedTo,
            SortOption? sortAssignedBy,
            SortOption? sortAssignedDate,
            SortOption? sortState,
            SortOption? sortLastUpdate,
            string expected) {
            //Arrange
            var filter = new FilterAssignmentRequest()
            {
                PageNumber = 1,
                PageSize = 10,
                SortAssetCode = sortAssetCode,
                SortAssetName = sortAssetName,
                SortAssignedBy = sortAssignedBy,
                SortAssignedDate = sortAssignedDate,
                SortAssignedTo = sortAssignedTo,
                SortState = sortState,
                SortLastUpdate = sortLastUpdate
            };

            _currentUserMock.Setup(m => m.UserId).Returns(_users[0].Id);
            _userManagerMock.Setup(m => m.Users).Returns(_users.BuildMock);

            _unitOfWorkMock.Setup(m => m.AssignmentRepository).Returns(_assignmentRepositoryMock.Object);
            _assignmentRepositoryMock.Setup(m => m.GetQueryableSet())
                .Returns(_assignments.BuildMock);

            var mock = _assignments.AsQueryable().BuildMock();

            //Act
            var result = await _assignmentService.FilterAssignmentAsync(filter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expected, result.Data.First().Id.ToString());
        }

        [Theory]
        [InlineData(null, "tridm ", null, 1)]
        [InlineData(null, " tri ", null, 1)]
        [InlineData(new[] { AssignmentState.Accepted }, null, null, 6)]
        [InlineData(new[] { AssignmentState.Accepted, AssignmentState.Declined }, null, null, 7)]
        [InlineData(new[] { AssignmentState.Declined }, "tridm", null, 0)]
        [InlineData(null, null, "2023-06-06", 1)]
        [InlineData(new[] { AssignmentState.Declined }, null, "2023-06-06", 0)]
        public async Task FilterAssignmentAsync_ShouldReturnCorrectDataWithFilter(
            AssignmentState[]? states,
            string? search,
            string? assignedDate,
            int expectedLength) {
            //Arrange
            var filter = new FilterAssignmentRequest()
            {
                PageNumber = 1,
                PageSize = 30,
                SortAssetCode = SortOption.Asc,
                States = states,
                Search = search,
                AssignedDate = assignedDate != null ? DateTime.Parse(assignedDate) : null
            };

            _currentUserMock.Setup(m => m.UserId).Returns(_users[0].Id);
            _userManagerMock.Setup(m => m.Users).Returns(_users.BuildMock);

            _unitOfWorkMock.Setup(m => m.AssignmentRepository).Returns(_assignmentRepositoryMock.Object);
            _assignmentRepositoryMock.Setup(m => m.GetQueryableSet())
                .Returns(_assignments.BuildMock);

            var mock = _assignments.AsQueryable().BuildMock();

            //Act
            var result = await _assignmentService.FilterAssignmentAsync(filter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedLength, result.Data.Count);
        }
    }
}
