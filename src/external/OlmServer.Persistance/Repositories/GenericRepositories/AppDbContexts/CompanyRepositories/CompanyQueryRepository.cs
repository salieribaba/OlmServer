using OlmServer.Domain.AppEntities;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories
{
    public class CompanyQueryRepository : AppQueryRepository<Company>, Domain.Repositories.GenericRepositories.AppDbContexts.CompanyRepositories.ICompanyQueryRepository
    {
        public CompanyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
