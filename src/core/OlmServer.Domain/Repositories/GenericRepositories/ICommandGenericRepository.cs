using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories
{
    public interface ICommandGenericRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task DeleteByIdAsync(string id);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
    }
}
