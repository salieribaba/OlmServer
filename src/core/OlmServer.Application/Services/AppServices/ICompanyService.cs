using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CompanyCommandCreate companyCreateRequest, CancellationToken cancellationToken);
        Task<Company?> GetCompanyByName(string name, CancellationToken cancellationToken = default);
        Task MigrateCompanyDatabase();
    }
}
