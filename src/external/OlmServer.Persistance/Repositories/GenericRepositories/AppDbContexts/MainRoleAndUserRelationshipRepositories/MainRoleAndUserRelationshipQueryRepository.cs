using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainRoleAndUserRelationshipRepositories
{
    public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationShip>, IMainRoleAndUserRelationshipQueryRepository
    {
        public MainRoleAndUserRelationshipQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
