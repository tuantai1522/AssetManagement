using AssetManagement.Application.Services.Implementations;
using AssetManagement.Data.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.Services.ReturningRequestTests
{
    public class SetupReturningRequestTest : SetupTest
    {
        protected readonly Mock<IReturningRequestRepository> _returningRequestRepositoryMock;
        protected readonly ReturningRequestService _returningRequestService;
        public SetupReturningRequestTest() : base()
        {
            _returningRequestRepositoryMock = new Mock<IReturningRequestRepository>();

            _returningRequestService = new ReturningRequestService(
                _unitOfWorkMock.Object, 
                _currentUserMock.Object,
                _userManagerMock.Object
            );
        }
    }
}
