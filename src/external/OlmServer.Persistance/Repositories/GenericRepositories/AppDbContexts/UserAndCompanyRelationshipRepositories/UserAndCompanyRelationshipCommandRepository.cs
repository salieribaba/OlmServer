using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories
{
    public class UserAndCompanyRelationshipCommandRepository : AppCommandRepository<AppUsersCompany>, IUserAndCompanyRelationshipCommandRepository
    {
        public UserAndCompanyRelationshipCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
