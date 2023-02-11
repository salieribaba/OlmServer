using Moq;
using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Application.Services.CompanyServices;
using OlmServer.Domain.CompanyEntities;
using Shouldly;
using Xunit;

namespace OlmServer.UnitTest.CompanyFeature.Commands
{
    public class UcafCreateCommandUnitTest
    {
        private readonly Mock<IUcafService> _ucafService;

        public UcafCreateCommandUnitTest()
        {
            _ucafService = new();
        }

        [Fact]
        public async Task UcafShouldBeNull()
        {
            string companyId = "585985c0-4576-4d62-ae67-59a6f72ae906";
            string code = "100.01.001";
            UniformChartOfAccount ucaf = await _ucafService.Object.GetByCodeAsync(companyId, code, default);
            ucaf.ShouldBeNull();
        }


        [Fact]
        public async Task UcafCreateCommandResponse()
        {
            var command = new UcafCreateCommand(
                Code: "100.01.001",
                Name: "Tl Kasa",
                Type: "M",
                CompanyId: "a3699ded-ea84-4766-ace5-fd187092ab32"
                );

            var handler = new UcafCreateCommandHandler(_ucafService.Object);
            var response = await handler.Handle(command, CancellationToken.None);

            Assert.NotNull(response);
            response.Mesaage.ShouldNotBeEmpty();

        }


    }
}
