using OlmServer.Domain.CompanyEntities;
using OlmServer.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace OlmServer.Domain.Repositories.GenericRepositories.UcafRepositories
{
    public interface IUcafQueryRepository : ICompanyDbRepositoryQuery<UniformChartOfAccount>
    {
    }
}
