using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep
{
    public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationShip>, IMainRoleAndRoleRelationshipQueryRepository
    {
        public MainRoleAndRoleRelationshipQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
