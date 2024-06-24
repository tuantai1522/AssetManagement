using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Microsoft.AspNetCore.Identity;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.Services.UsersTests
{
	public class UpdateUserAsyncTests : UserServiceTestBase
	{
		public UpdateUserAsyncTests() : base() { }
		[Fact]
		public async Task UpdateUserAsync_InvalidGender_ThrowsBadRequestException()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = Fixture.Create<UpdateUserRequest>();
			request.Gender = "InvalidGender";

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
		[Fact]
		public async Task UpdateUserAsync_DateOfBirthInFuture_ThrowsBadRequestException()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = DateTime.Now.AddYears(1), // Date of birth in the future
				Gender = "Male",
				JoinedDate = new DateTime(2024, 6, 21, 0, 0, 0, DateTimeKind.Local),
				Type = "Admin"
			};

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
		[Fact]
		public async Task UpdateUserAsync_DateOfBirthLessThan18_ThrowsBadRequestException()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2020, 10, 11, 0, 0, 0, DateTimeKind.Local), // Date of birth less than 18
				Gender = "Male",
				JoinedDate = new DateTime(2024, 6, 21, 0, 0, 0, DateTimeKind.Local),
				Type = "Admin"
			};

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
		[Fact]
		public async Task UpdateUserAsync_JoinedDateOnWeekend_ThrowsBadRequestException()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2002, 10, 11, 0, 0, 0, DateTimeKind.Local), 
				Gender = "Male",
				JoinedDate = new DateTime(2023, 6, 24, 0, 0, 0, DateTimeKind.Local), // A Saturday
				Type = "Admin"
			};

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
		[Fact]
		public async Task UpdateUserAsync_JoinedDateLessThanDateOfBirth_ThrowsBadRequestException()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2002, 10, 11, 0, 0, 0, DateTimeKind.Local),
				Gender = "Male",
				JoinedDate = new DateTime(2010, 6, 24, 0, 0, 0, DateTimeKind.Local), 
				Type = "Admin"
			};

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
		[Fact]
		public async Task UpdateUserAsync_ValidateTypeAsync_RoleNotFound_ThrowsBadRequestException()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2002, 10, 11, 0, 0, 0, DateTimeKind.Local),
				Gender = "Male",
				JoinedDate = new DateTime(2024, 6, 24, 0, 0, 0, DateTimeKind.Local),
				Type = "NonExistentRole"
			};
			RoleManagerMock.Setup(rm => rm.Roles).Returns(Roles.AsQueryable().BuildMockDbSet().Object);

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
		[Fact]
		public async Task UpdateUserAsync_Success()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2002, 10, 11, 0, 0, 0, DateTimeKind.Local),
				Gender = "Male",
				JoinedDate = new DateTime(2024, 6, 24, 0, 0, 0, DateTimeKind.Local),
				Type = "Staff"
			};
			RoleManagerMock.Setup(rm => rm.Roles).Returns(Roles.AsQueryable().BuildMockDbSet().Object);
			UserManagerMock.Setup(um => um.Users).Returns(Users.AsQueryable().BuildMockDbSet().Object);
			UserManagerMock.Setup(um => um.GetRolesAsync(It.IsAny<AppUser>())).ReturnsAsync(new List<string> { "Admin" });
			RoleManagerMock.Setup(rm => rm.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(Roles.Find(r => r.Name == request.Type));
			UserManagerMock.Setup(um => um.UpdateAsync(It.IsAny<AppUser>())).ReturnsAsync(IdentityResult.Success)
				.Verifiable();

			// Act
			var result = await UserService.UpdateUserAsync(userId, request);

			// Assert
			Assert.NotNull(result);
			UserManagerMock.Verify(um => um.UpdateAsync(It.IsAny<AppUser>()), Times.Once);
		}

		[Fact]
		public async Task UpdateUserAsync_UserNotFound()
		{
			// Arrange
			var userId = Guid.NewGuid();
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2002, 10, 11, 0, 0, 0, DateTimeKind.Local),
				Gender = "Male",
				JoinedDate = new DateTime(2024, 6, 24, 0, 0, 0, DateTimeKind.Local),
				Type = "Staff"
			};
			RoleManagerMock.Setup(rm => rm.Roles).Returns(Roles.AsQueryable().BuildMockDbSet().Object);
			UserManagerMock.Setup(um => um.Users).Returns(Users.AsQueryable().BuildMockDbSet().Object);
			UserManagerMock.Setup(um => um.UpdateAsync(It.IsAny<AppUser>())).ReturnsAsync(IdentityResult.Success)
				.Verifiable();

			// Act & Assert
			await Assert.ThrowsAsync<NotFoundException>(() => UserService.UpdateUserAsync(userId, request));
			UserManagerMock.Verify(um => um.UpdateAsync(It.IsAny<AppUser>()), Times.Never);
		}
		[Fact]
		public async Task UpdateUserAsync_FailedUpdate()
		{
			// Arrange
			var userId = Users[0].Id;
			var request = new UpdateUserRequest()
			{
				DateOfBirth = new DateTime(2002, 10, 11, 0, 0, 0, DateTimeKind.Local),
				Gender = "Male",
				JoinedDate = new DateTime(2024, 6, 24, 0, 0, 0, DateTimeKind.Local),
				Type = "Admin"
			};
			RoleManagerMock.Setup(rm => rm.Roles).Returns(Roles.AsQueryable().BuildMockDbSet().Object);
			UserManagerMock.Setup(um => um.Users).Returns(Users.AsQueryable().BuildMockDbSet().Object);
			UserManagerMock.Setup(um => um.GetRolesAsync(It.IsAny<AppUser>())).ReturnsAsync(new List<string> { "Admin" });
			UserManagerMock.Setup(um => um.UpdateAsync(It.IsAny<AppUser>())).ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Update failed" }));

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => UserService.UpdateUserAsync(userId, request));
		}
	}
}
