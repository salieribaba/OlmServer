using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts
{
    public interface IAppCommandRepository<T> :IRepository<T>, ICommandGenericRepository<T> where T : BaseEntity
    {


    }
}
