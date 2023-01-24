using Moq;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public class UpdateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _appRoleService;

        public UpdateRoleCommandUnitTest()
        {
            _appRoleService = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBeNull()
        {
            _ = _appRoleService.Setup(x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());


        }

        [Fact]
        public async Task AppRoleCodeShouldBeUniq()
        {
            AppRole checkRoleCode = await _appRoleService.Object.GetByCode("Ucaf.code");
            checkRoleCode.ShouldBeNull();
        }

        [Fact]
        public async Task UpdateRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(
                Id: "22fcd9cf-d5fb-4658-ae04-a3011ce10afa",
                Code: "Ucaf.code",
                Name: "Hesap Planı Kayıt Ekleme"
                );

            _appRoleService.Setup(
            x => x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());

            var handler = new UpdateRoleCommandHandler(_appRoleService.Object);
            UpdateRoleCommandResponse response = await handler.Handle(command, new CancellationToken());

            _ = response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();




        }
    }
}
