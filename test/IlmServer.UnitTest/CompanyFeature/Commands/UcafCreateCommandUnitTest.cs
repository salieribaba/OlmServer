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
            UniformChartOfAccount ucaf = await _ucafService.Object.GetByCode("100.01.001");
            Assert.Null(ucaf);
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
