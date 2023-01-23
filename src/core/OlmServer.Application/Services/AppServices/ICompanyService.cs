using OlmServer.Application.Features.AppFeatures.Companyfeatures.Commands.CompanyCreate;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CompanyCommandCreate companyCreateRequest);
        Task<Company?> GetCompanyByName(string name);
        Task MigrateCompanyDatabase();
    }
}
