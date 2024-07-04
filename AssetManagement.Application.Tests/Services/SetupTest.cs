using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AutoFixture.AutoMoq;
using AutoFixture;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Moq;
using AssetManagement.Application.Extensions;

namespace AssetManagement.Application.Tests.Services
{
	public class SetupTest
	{
		protected readonly IFixture _fixture;
		protected readonly Mock<ICurrentUser> _currentUserMock;
		protected readonly Mock<UserManager<AppUser>> _userManagerMock;
		protected readonly IMapper _mapperConfig;
		protected readonly Mock<IUnitOfWork> _unitOfWorkMock;

		protected List<Role> Roles = new List<Role>();
		protected List<AppUser> Users = new List<AppUser>();
		protected List<Category> Categories = new List<Category>();
		protected List<Asset> Assets = new List<Asset>();

		public SetupTest()
		{
			_fixture = new Fixture().Customize(new AutoMoqCustomization());
			_fixture.Behaviors.Add(new OmitOnRecursionBehavior());

			_currentUserMock = new Mock<ICurrentUser>();
			_userManagerMock = _fixture.Freeze<Mock<UserManager<AppUser>>>();
			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new MappingProfile());
			});
			_mapperConfig = mappingConfig.CreateMapper();
			_unitOfWorkMock = new Mock<IUnitOfWork>();

			Setup();
		}
		#region setup
		protected void Setup()
		{
			Roles = [
			new Role()
		{
			Id = Guid.NewGuid(),
			Name = "Admin",
			NormalizedName = "ADMIN",
		},
		new Role()
		{
			Id = Guid.NewGuid(),
			Name = "Staff",
			NormalizedName = "STAFF",
		}
			];

			Users = [
			   new AppUser (){
			Id = Guid.NewGuid(),
			FirstName = "Admin",
			LastName = "1",
			StaffCode = "SD0001",
			JoinedDate = DateTime.Now,
			Location = Location.HCM.ToString(),
			IsDisabled = false,
			UserRoles = [
				new UserRole() {
				Role = Roles[0]
				}
			]
		}
			];

			for (int i = 2; i <= 9; i++)
			{
				Users.Add(new AppUser
				{
					Id = Guid.NewGuid(),
					FirstName = "Staff",
					LastName = i.ToString(),
					StaffCode = $"SD{i:D4}",
					JoinedDate = DateTime.Now.AddDays(i),
					Location = Location.HCM.ToString(),
					IsDisabled = false,
					UserRoles = [
					new UserRole
				{
					Role = Roles[1]
				}
					]
				});
			}

			Users.Add(
				new AppUser()
				{
					Id = Guid.NewGuid(),
					FirstName = "Admin",
					LastName = "10",
					StaffCode = "SD0010",
					JoinedDate = DateTime.Now.AddHours(2),
					Location = Location.HCM.ToString(),
					IsDisabled = false,
					UserRoles = [
						new UserRole() {
						Role = Roles[0]
					}
					]
				}
				);
			Categories.AddRange(
				[
				new Category()
				{
					Id= Guid.NewGuid(),
					Name = "Laptop",
					Prefix = "LA"
				},
				new Category()
				{
					Id= Guid.NewGuid(),
					Name = "Monitor",
					Prefix = "M"
				},
				]
				);
			for (int i = 1; i <= 4; i++)
			{
				Assets.Add(
					new Asset()
					{
						Id = Guid.NewGuid(),
						Name = $"Laptop0{i}",
						AssetCode = $"LA00{i}",
						Category = Categories[0],
						CategoryId = Categories[0].Id,
						CreatedAt = DateTime.Now,
						InstalledDate = DateTime.Now,
						LastUpdated = DateTime.Now,	
						Location = Location.HCM.ToString(),
						Specification = $"Specification of {i}",
						State = AssetState.Available,
					}
					);
			}
			for (int i = 5; i <= 8; i++)
			{
				Assets.Add(
					new Asset()
					{
						Id = Guid.NewGuid(),
						Name = $"Monitor0{i}",
						AssetCode = $"M00{i}",
						Category = Categories[1],
						CategoryId = Categories[1].Id,
						CreatedAt = DateTime.Now,
						InstalledDate = DateTime.Now,
						LastUpdated = DateTime.Now,
						Location = Location.HCM.ToString(),
						Specification = $"Specification of {i}",
						State = AssetState.Available,
					}
					);
			}

		}
		#endregion
	}
}
