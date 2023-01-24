using Moq;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{

    public class DeleteRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleService;

        public DeleteRoleCommandUnitTest()
        {
            _roleService = new Mock<IRoleService>();
        }

        [Fact]
        public async Task AppRoleShouldBeNotNull()
        {
            _ = _roleService.Setup(x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());

        }

        [Fact]
        public async Task DeleteRoleCommandResponseShouldNotBeNull()
        {
            var command = new DeleteRoleCommand(Id: "22fcd9cf-d5fb-4658-ae04-a3011ce10afa");

            _roleService.Setup(
          x => x.GetById(It.IsAny<string>()))
          .ReturnsAsync(new AppRole());

            var handler = new DeleteRoleCommandHandler(_roleService.Object);
            DeleteRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }
    }
}
