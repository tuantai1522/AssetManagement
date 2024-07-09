using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Requests;
using AssetManagement.Contracts.Enums;
using MockQueryable.Moq;

namespace AssetManagement.Application.Tests.Services.ReturningRequestTests {
    public class FilterReturningRequestTest : SetupReturningRequestServiceTest {
        public FilterReturningRequestTest() : base() {
        }

        [Theory]
        [InlineData(1, null)]
        [InlineData(0, 6)]
        [InlineData(-1, 4)]
        [InlineData(1, 0)]
        [InlineData(1, -1)]
        [InlineData(null, 4)]
        public async Task FilterReturningAsync_ShouldReturnPagingDto_WithFilteredAssignments(int? pageNumber, int? pageSize) {
            // Arrange

            var filter = new FilterReturningRequest()
            {
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            _currentUserMock.Setup(m => m.UserId).Returns(_users[0].Id);
            _userManagerMock.Setup(m => m.Users).Returns(_users.BuildMock);

            _unitOfWorkMock.Setup(m => m.ReturningRequestRepository).Returns(_returningRequestRepositoryMock.Object);
            _returningRequestRepositoryMock.Setup(m => m.GetQueryableSet())
                .Returns(_returningRequests.BuildMock);

            // Act
            var result = await _returningRequestService.FilterReturningAsync(filter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(_returningRequests.Count(), result.TotalItemCount);
            Assert.Equal(5, result.Data.Count);
        }

        [Theory]
        [InlineData(SortOption.Asc, null, null, null, null, null, null, "c57d03b0-c899-4027-bee1-80a367917ccc")]
        [InlineData(SortOption.Desc, null, null, null, null, null, null, "fd14ce2a-c4b4-4e94-bd46-5a26dbcb89dc")]
        [InlineData(null, SortOption.Asc, null, null, null, null, null, "b998ae03-f261-4957-b597-07a5b6db3ad1")]
        [InlineData(null, SortOption.Desc, null, null, null, null, null, "fd14ce2a-c4b4-4e94-bd46-5a26dbcb89dc")]
        [InlineData(null, null, SortOption.Asc, null, null, null, null, "345ce54d-1b11-4aca-ab35-2ab1fe3858a3")]
        [InlineData(null, null, SortOption.Desc, null, null, null, null, "fd14ce2a-c4b4-4e94-bd46-5a26dbcb89dc")]
        [InlineData(null, null, null, SortOption.Asc, null, null, null, "77bb2f45-1187-4924-b8ff-00f7bc42fef7")]
        [InlineData(null, null, null, SortOption.Desc, null, null, null, "4c082762-48da-402a-a26b-15f1025e5fab")]
        [InlineData(null, null, null, null, SortOption.Asc, null, null, "77bb2f45-1187-4924-b8ff-00f7bc42fef7")]
        [InlineData(null, null, null, null, SortOption.Desc, null, null, "b998ae03-f261-4957-b597-07a5b6db3ad1")]
        [InlineData(null, null, null, null, null, SortOption.Asc, null, "77bb2f45-1187-4924-b8ff-00f7bc42fef7")]
        [InlineData(null, null, null, null, null, SortOption.Desc, null, "345ce54d-1b11-4aca-ab35-2ab1fe3858a3")]
        [InlineData(null, null, null, null, null, null, SortOption.Asc, "345ce54d-1b11-4aca-ab35-2ab1fe3858a3")]
        [InlineData(null, null, null, null, null, null, SortOption.Desc, "fd14ce2a-c4b4-4e94-bd46-5a26dbcb89dc")]
        public async Task FilterAssignmentAsync_ShouldReturnCorrectSortOrder(
            SortOption? sortAssetCode,
            SortOption? sortAssetName,
            SortOption? sortAcceptedBy,
            SortOption? sortAssignedDate,
            SortOption? sortRequestedBy,
            SortOption? sortState,
            SortOption? sortReturnedDate,
            string expected) {
            //Arrange
            var filter = new FilterReturningRequest()
            {
                PageNumber = 1,
                PageSize = 10,
                SortAssetCode = sortAssetCode,
                SortAssetName = sortAssetName,
                SortAcceptedBy = sortAcceptedBy,
                SortAssignedDate = sortAssignedDate,
                SortRequestedBy = sortRequestedBy,
                SortState = sortState,
                SortReturnedDate = sortReturnedDate
            };

            _currentUserMock.Setup(m => m.UserId).Returns(_users[0].Id);
            _userManagerMock.Setup(m => m.Users).Returns(_users.BuildMock);

            _unitOfWorkMock.Setup(m => m.ReturningRequestRepository).Returns(_returningRequestRepositoryMock.Object);
            _returningRequestRepositoryMock.Setup(m => m.GetQueryableSet())
                .Returns(_returningRequests.BuildMock);

            var mock = _assignments.AsQueryable().BuildMock();

            //Act
            var result = await _returningRequestService.FilterReturningAsync(filter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expected, result.Data.First().Id.ToString());
        }
    }
}
