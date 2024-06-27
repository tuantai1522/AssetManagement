using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Domain.Entities;
using AutoFixture;
using MockQueryable.Moq;
using Moq;

namespace AssetManagement.Application.Tests.Services.CategoryTests
{
    public class GetAllAsyncTest : CategoryServiceTestSetup
    {
        public GetAllAsyncTest() : base() { }

        [Fact]
        public async Task GetAllAsync_ShouldReturnCategories_WhenCategoriesExist()
        {
            //Arrange
            int categoriesCount = 100;
            var mockCategories = _fixture.Build<Category>().CreateMany(categoriesCount).AsQueryable().BuildMock();
            _mockCategoryRepository.Setup(c => c.GetQueryableSet()).Returns(mockCategories);
            _mockUnitOfWork.Setup(u => u.CategoryRepository).Returns(_mockCategoryRepository.Object);

            var request = new GetAllCategoryRequest
            {
                PageSize = 15,
                PageNumber = 2
            };

            //Act
            var result = await _categoryService.GetAllAsync(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.TotalItemCount, categoriesCount);
            Assert.Equal(result.PageSize, request.PageSize);
            Assert.Equal(result.CurrentPage, request.PageNumber);
            Assert.Equal(result.Data.Count, request.PageSize);
        }
    }
}
