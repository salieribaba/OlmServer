using OlmServer.Domain.AppEntities.Abstractions;
using System.Linq.Expressions;

namespace OlmServer.Domain.Repositories
{
    public interface IRepositoryQuery<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAllWhere(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(string id);
        Task<T> GetFirstAsync();
        Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression);
        
        
        
    }
   
}
