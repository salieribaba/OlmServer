using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;

namespace OlmServer.Application.Services.CompanyServices
{
    public interface IUcafService
    {
        Task CreateUcafAsync(UcafCreateRequest request);
    }
}
