using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories
{
    public class UserAndCompanyRelationshipQueryRepository : AppQueryRepository<AppUsersCompany>, IUserAndCompanyRelationshipQueryRepository
    {
        public UserAndCompanyRelationshipQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
