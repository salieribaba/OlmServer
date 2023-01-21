using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.Repositories;
using OlmServer.Persistance.Contexts;
using System.Linq.Expressions;

namespace OlmServer.Persistance.Repositories
{
    public class RepositoryQuery<T> : IRepositoryQuery<T> where T : BaseEntity
    {
        public static readonly Func<CompanyDbContext, string, Task<T>> GetEntityById =
            EF.CompileAsyncQuery((CompanyDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(x => x.Id == id));
        private CompanyDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = dbContext as CompanyDbContext;
            Entity= _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public IQueryable<T> GetAllWhere(Expression<Func<T, bool>> predicate)
        {
            return Entity.Where(predicate).AsQueryable();
        }

        public async Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await GetEntityById(_context, id);
        }

        public async Task<T> GetFirstAsync()
        {
            return await Entity.FirstOrDefaultAsync();
        }
    }
}
