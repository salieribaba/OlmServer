using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories
{
    public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
