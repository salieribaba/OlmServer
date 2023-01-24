using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Application.Services.CompanyServices
{
    public interface IUcafService
    {
        Task CreateUcafAsync(UcafCreateCommand request, CancellationToken cancellationToken);
        Task<UniformChartOfAccount> GetByCode(string code);
        
    }
}
