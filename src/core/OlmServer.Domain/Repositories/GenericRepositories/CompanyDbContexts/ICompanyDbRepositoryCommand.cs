using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbRepositoryCommand<T> : ICompanyDbRepository<T>, ICommandGenericRepository<T> where T : BaseEntity
    {
    }
}
