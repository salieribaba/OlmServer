using Moq;
using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.Features.AppFeatures.CompanyFeatures.UcafFeatures.Commands
{
    public class CreateCompanyCommandUnitTest
    {
        private readonly Mock<ICompanyService> _companyService;

        public CreateCompanyCommandUnitTest()
        {
            _companyService = new();
        }

        [Fact]
        public async Task CompanyShouldByNull()
        {
            Company company = (await _companyService.Object.GetCompanyByName("test"))!;
            Assert.Null(company);
        }

        [Fact]
        public async Task CompanyCommandCreateResponseNotNull()
        {
            var command = new CompanyCommandCreate(
                 Name :"test",
                ServerName : "DESKTOP-Q809USI",
                DatabaseName : "OlmServer",
                UserId : "",
                Password : "");

            var handler = new CompanyCommandCreateHandler(_companyService.Object);
            CompanyCommandCreateResponse response = await handler.Handle(command, CancellationToken.None);
            Assert.NotNull(response);
            response.Message.ShouldNotBeEmpty();
        }

    }
}
