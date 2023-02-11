using OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate;
using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Application.Services.CompanyServices
{
    public interface IUcafService
    {
        Task CreateUcafAsync(UcafCreateCommand request, CancellationToken cancellationToken);
        Task<UniformChartOfAccount> GetByCodeAsync(string companyId, string code, CancellationToken cancellationToken);
        Task CreateMainUcafsToCompanyAsync(string companyId, CancellationToken cancellationToken);
        Task<IList<UniformChartOfAccount>> GetAllAsync(string companyId);
        Task RemoveByIdUcafAsync(string id, string companyId);
        Task<bool> CheckRemoveByIdUcafIsGroupAndAvailable(string id, string companyId);
        Task<UniformChartOfAccount> GetByIdAsync(string id, string companyId);
        Task UpdateUcafAsync(UniformChartOfAccount uniformChartOfAccount, string companyId);

    }
}
