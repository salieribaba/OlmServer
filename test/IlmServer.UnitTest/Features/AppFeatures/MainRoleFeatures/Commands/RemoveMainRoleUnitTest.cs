using Moq;
using OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRoles;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.MainRoleFeatures.Commands
{
    public class RemoveMainRoleUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleServiceMock;

        public RemoveMainRoleUnitTest()
        {
            _mainRoleServiceMock = new();
        }

        [Fact]
        public async Task RemoveMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new RemoveMainRoleCommand(
                Id: "585985c0-4576-4d62-ae67-59a6f72ae906");

            var handler = new RemoveMainRoleHandler(_mainRoleServiceMock.Object);

            RemoveMainRoleResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }

    }
}
