using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainRoleAndRoleRLSRep
{
    public class MainRoleAndRoleRelationshipCommandRepository : AppCommandRepository<MainRoleAndRoleRelationShip>, IMainRoleAndRoleRelationshipCommandRepository
    {
        public MainRoleAndRoleRelationshipCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
