using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContext;

namespace OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts.UserAndCompanyRelationshipRepositories
{
    public interface IUserAndCompanyRelationshipQueryRepository : IAppQueryRepository<AppUsersCompany>
    {
    }
}
