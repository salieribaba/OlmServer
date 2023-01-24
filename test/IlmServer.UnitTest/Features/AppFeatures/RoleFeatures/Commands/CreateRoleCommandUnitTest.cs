using Moq;
using NPOI.SS.Formula.Functions;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.RoleFeatures.Commands
{
    public class CreateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _appRoleService;

        public CreateRoleCommandUnitTest()
        {
            _appRoleService = new();
        }

        [Fact]
        public async Task AppRoleShouldBeNull()
        {
            AppRole appRole = (await _appRoleService.Object.GetByCode("Ucaf.Create"))!;
            Assert.Null(appRole);
        }

        [Fact]
        public async Task CreateRoleCommandResponseShouldNotBeNull()
        {
            var command = new CreateRoleCommand(
                Code: "Ucaf.code",
                Name: "Hesap Planı Kayıt Ekleme"
                );

            var handler = new CreateRoleCommandHandler(_appRoleService.Object);
            var response = await handler.Handle(command, CancellationToken.None);

            Assert.NotNull(response);
            response.Message.ShouldNotBeEmpty();




        }
    }
}
