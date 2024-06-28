using AssetManagement.Application.Common.Constants;
using AssetManagement.Contracts.Dtos.CategoryDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using Moq;

namespace AssetManagement.Application.Tests.Services.CategoryTests;

public class CreateAsyncTest : CategoryServiceTestSetup
{
    public CreateAsyncTest() : base() { }

    [Theory]
    [InlineData("Workstation", "WS")]
    [InlineData("Keyboard", "KB")]
    [InlineData("Mouse", "MB")]
    [InlineData("Monitor", "MN")]
    [InlineData("Smartphone", "SP")]
    public async Task CreateAsync_ShouldReturnNewCategory_WhenSuccess(string name, string prefix)
    {
        //Arrange
        var request = new CreateCategoryRequest
        { 
            Name = name, 
            Prefix = prefix
        };
        var category = new Category
        {
            Name = name,
            Prefix = prefix,
        };

        _mockCategoryRepository.Setup(c => c.Add(It.IsAny<Category>())).Returns(category);
        _mockUnitOfWork.Setup(u => u.CategoryRepository).Returns(_mockCategoryRepository.Object);
        _mockUnitOfWork.Setup(u => u.SaveChangesAsync()).Returns(Task.CompletedTask);

        //Act
        var result = await _categoryService.CreateAsync(request);

        //Assert
        Assert.NotNull(result);
        Assert.Equal(request.Name, result.Name);
        Assert.Equal(request.Prefix, result.Prefix);
    }

    [Theory]
    [InlineData("@Workstation", "WS")]
    [InlineData("Keybo-ard", "KB")]
    [InlineData("Mouse/", "MB")]
    [InlineData("Monit?or", "MN")]
    [InlineData("Smar%tphone", "SP")]
    public async Task CreateAsync_ShouldThrowBadRequestException_WhenNameContainsInvalidCharacters(string name, string prefix)
    {
        //Arrange
        var request = new CreateCategoryRequest
        {
            Name = name,
            Prefix = prefix
        };

        //Act && Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _categoryService.CreateAsync(request));
        Assert.Equal(ErrorStrings.INVALID_CATEGORY_NAME_CHARACTERS, exception.Message);
    }

    [Theory]
    [InlineData("Workstation", "W S")]
    [InlineData("Keyboard", "K%B")]
    [InlineData("Mouse", "MB*")]
    [InlineData("Monitor", "-MN")]
    [InlineData("Smartphone", ";SP")]
    public async Task CreateAsync_ShouldThrowBadRequestException_WhenPrefixContainsInvalidCharacters(string name, string prefix)
    {
        //Arrange
        var request = new CreateCategoryRequest
        {
            Name = name,
            Prefix = prefix
        };

        //Act && Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _categoryService.CreateAsync(request));
        Assert.Equal(ErrorStrings.INVALID_CATEGORY_PREFIX_CHARACTERS, exception.Message);
    }

    [Theory]
    [InlineData("Workstation", "WS")]
    [InlineData("Keyboard", "KB")]
    [InlineData("Mouse", "MB")]
    [InlineData("Monitor", "MN")]
    [InlineData("Smartphone", "SP")]
    public async Task CreateAsync_ShouldThrowBadRequestException_WhenNameAlreadyExists(string name, string prefix)
    {
        //Arrange
        var request = new CreateCategoryRequest
        {
            Name = name,
            Prefix = prefix
        };
        var category = new Category
        {
            Name = name,
            Prefix = "FOO",
        };

        _mockCategoryRepository.Setup(c => c.FindOne(c => c.Name == request.Name)).ReturnsAsync(category);
        _mockUnitOfWork.Setup(u => u.CategoryRepository).Returns(_mockCategoryRepository.Object);

        //Act && Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _categoryService.CreateAsync(request));
        Assert.Equal(ErrorStrings.CATEGORY_NAME_ALREADY_EXISTS, exception.Message);
    }

    [Theory]
    [InlineData("Workstation", "WS")]
    [InlineData("Keyboard", "KB")]
    [InlineData("Mouse", "MB")]
    [InlineData("Monitor", "MN")]
    [InlineData("Smartphone", "SP")]
    public async Task CreateAsync_ShouldThrowBadRequestException_WhenPrefixAlreadyExists(string name, string prefix)
    {
        //Arrange
        var request = new CreateCategoryRequest
        {
            Name = name,
            Prefix = prefix
        };
        var category = new Category
        {
            Name = "FOO",
            Prefix = prefix,
        };

        _mockCategoryRepository.Setup(c => c.FindOne(c => c.Prefix == request.Prefix)).ReturnsAsync(category);
        _mockUnitOfWork.Setup(u => u.CategoryRepository).Returns(_mockCategoryRepository.Object);

        //Act && Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _categoryService.CreateAsync(request));
        Assert.Equal(ErrorStrings.CATEGORY_PREFIX_ALREADY_EXISTS, exception.Message);
    }
}

