using Moq;
using OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.MainRoleUpdates;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.MainRoleFeatures.Commands
{
    public class MainRoleUpdateCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleService;

        public MainRoleUpdateCommandUnitTest()
        {
            _mainRoleService = new();
        }




        [Fact]
        public async Task MainRoleShouldNotBeNull()
        {
            _mainRoleService
                .Setup(x => x.GetByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new MainRole());
        }

        [Fact]
        public async Task UpdateMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new MainRoleUpdateCommand(
                Id: "585985c0-4576-4d62-ae67-59a6f72ae906",
                Title: "Admin");

            var handler = new MainRoleUpdateCommandHandler(_mainRoleService.Object);

            _mainRoleService
               .Setup(x => x.GetByIdAsync(It.IsAny<string>()))
               .ReturnsAsync(new MainRole());

            MainRoleUpdateCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
