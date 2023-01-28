using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbRepositoryQuery<T> : ICompanyDbRepository<T>, IQueryGenericRepository<T> where T : BaseEntity
    {
    }

}
