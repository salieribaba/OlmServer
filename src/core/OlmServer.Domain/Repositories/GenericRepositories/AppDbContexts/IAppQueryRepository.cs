using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories.AppDbContext
{
    public interface IAppQueryRepository<T> :IQueryGenericRepository<T>, IRepository<T> where T : BaseEntity
    {
    }
}
