using Moq;
using OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRoles;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.MainRoleFeatures.Commands
{
    public class CreateMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleServiceMock;

        public CreateMainRoleCommandUnitTest()
        {
            _mainRoleServiceMock = new();
        }

        [Fact]
        public async Task MainRoleShouldBeNull()
        {
            MainRole mainRole = await _mainRoleServiceMock.Object.GetByTitleAndCompanyId(
                title: "Admin",
                companyId: "585985c0-4576-4d62-ae67-59a6f72ae906",
                default
                );
            mainRole.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new MainRoleCreateCommand(
                Title: "Admin",
                CompanyId: "585985c0-4576-4d62-ae67-59a6f72ae906");

            var handler = new MainRoleCreateHandler(_mainRoleServiceMock.Object);

            MainRoleCreateResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
