using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories
{
    public class MainRoleAndUserRelationshipCommandRepository : AppCommandRepository<MainRoleAndUserRelationShip>, IMainRoleAndUserRelationshipCommandRepository
    {
        public MainRoleAndUserRelationshipCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
