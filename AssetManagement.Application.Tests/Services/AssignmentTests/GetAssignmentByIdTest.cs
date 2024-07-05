using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using Microsoft.OpenApi.Any;
using MockQueryable.Moq;
using Moq;
using System.Linq.Expressions;

namespace AssetManagement.Application.Tests.Services.AssignmentTests
{
    public class GetAssignmentByIdTest : SetupAssignmentServiceTest
    {
        public GetAssignmentByIdTest() : base() { }
		[Fact]
		public async Task GetAssignmentByIdAsync_AssignmentNotFound_ThrowsNotFoundException()
		{
			// Arrange
			_unitOfWorkMock.Setup(u => u.AssignmentRepository.GetAssignmentByIdAsync(It.IsAny<Guid>()))
						   .ReturnsAsync(default(Assignment));

			// Act & Assert
			await Assert.ThrowsAsync<NotFoundException>(() => _assignmentService.GetAssignmentByIdAsync(Guid.NewGuid()));
		}
		[Fact]
		public async Task GetAssignmentByIdAsync_AssignmentFound_ReturnsAssignmentDetailResponse()
		{
			// Arrange
			var assignment = new Assignment { Id = Guid.NewGuid() };
			_unitOfWorkMock.Setup(u => u.AssignmentRepository.GetAssignmentByIdAsync(assignment.Id))
						   .ReturnsAsync(assignment);

			// Act
			var result = await _assignmentService.GetAssignmentByIdAsync(assignment.Id);

			// Assert
			Assert.NotNull(result);
			Assert.Equal(assignment.Id, result.Id);
		}
	}
}
