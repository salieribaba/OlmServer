using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainroleRepositories
{
    public class MainRoleQueryRepository : AppQueryRepository<MainRole>, IMainRoleQueryRepository
    {
        public MainRoleQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
