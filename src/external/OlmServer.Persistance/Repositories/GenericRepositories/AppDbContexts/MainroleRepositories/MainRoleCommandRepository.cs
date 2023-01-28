using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.MainRoleRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.MainroleRepositories
{
    public class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepository
    {
        public MainRoleCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
