using OlmServer.Domain.AppEntities.Abstractions;
using System.Linq.Expressions;

namespace OlmServer.Domain.Repositories.GenericRepositories
{
    public interface IQueryGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool isTracking = true);
        IQueryable<T> GetAllWhere(Expression<Func<T, bool>> predicate, bool isTracking = true);
        Task<T> GetByIdAsync(string id, bool isTracking = true);
        Task<T> GetFirstAsync(bool isTracking = true);
        Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default, bool isTracking = true);

    }
}
