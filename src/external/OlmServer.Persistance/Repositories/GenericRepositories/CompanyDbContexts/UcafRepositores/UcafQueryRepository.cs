using OlmServer.Domain.CompanyEntities;
using OlmServer.Domain.Repositories.GenericRepositories.UcafRepositories;
using OlmServer.Persistance.Repositories.GenericRepositories.CompanyDbContexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.CompanyDbContexts.UcafRepositores
{
    public class UcafRepositoryQuery : CompanyDbRepositoryQuery<UniformChartOfAccount>, IUcafQueryRepository
    {
    }
}
