using Moq;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Queries.RolesGetAll;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.RoleFeatures.Queries
{
    public class RolesGetAllQueryUnitTest
    {
        private readonly Mock<IRoleService> _roleService;

        public RolesGetAllQueryUnitTest()
        {
            _roleService = new();
        }

        [Fact]
        public async Task RolesGetAllQueryResponseShouldNotBeNull()
        {
            _roleService.Setup(x => x.GetAllRolesAsync())
                .ReturnsAsync(new List<AppRole>());

        }
    }
}
