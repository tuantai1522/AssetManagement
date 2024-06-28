using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;
using AutoFixture;
using AutoMapper;
using Moq;

namespace AssetManagement.Application.Tests.Services.CategoryTests;

public class CategoryServiceTestSetup
{
    protected readonly ICategoryService _categoryService;
    protected readonly Fixture _fixture;
    protected readonly IMapper _mapper;
    protected readonly Mock<IUnitOfWork> _mockUnitOfWork;
    protected readonly Mock<ICategoryRepository> _mockCategoryRepository;

    public CategoryServiceTestSetup()
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        _mapper = mappingConfig.CreateMapper();

        _mockCategoryRepository = new Mock<ICategoryRepository>();
        _mockUnitOfWork = new Mock<IUnitOfWork>();

        _fixture = new Fixture();
        _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => _fixture.Behaviors.Remove(b));
        _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        _categoryService = new CategoryService(_mockUnitOfWork.Object, _mapper);
    }
}

