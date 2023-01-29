using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContext;
using OlmServer.Persistance.Contexts;
using System.Linq.Expressions;
using System.Threading;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts
{
    public class AppQueryRepository<T> : IAppQueryRepository<T> where T : BaseEntity
    {
        public static readonly Func<AppDbContext, string, bool, Task<T>> GetEntityById =
         EF.CompileAsyncQuery((AppDbContext context, string id, bool isTracking) =>
      context.Set<T>().FirstOrDefault(x => x.Id == id));


        private AppDbContext _context;

        public AppQueryRepository(AppDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = dbContext as AppDbContext;
            Entity = _context.Set<T>();
        }

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            if (isTracking)
            {
                return Entity.AsQueryable();
            }
            else
            {
                return Entity.AsNoTracking().AsQueryable();
            }
        }

        public IQueryable<T> GetAllWhere(Expression<Func<T, bool>> predicate, bool isTracking = true)
        {
            if (isTracking)
            {
                return Entity.Where(predicate).AsQueryable();
            }
            else
            {
                return Entity.Where(predicate).AsNoTracking().AsQueryable();
            }
        }

        public async Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default, bool isTracking = true)
        {
            T entity = null;
            if (!isTracking)
                entity = await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync(cancellationToken);
            else
                entity = await Entity.Where(expression).FirstOrDefaultAsync(cancellationToken);

            return entity;
        }

        public async Task<T> GetByIdAsync(string id, bool isTracking = true)
        {
            return await GetEntityById(_context, id, isTracking);
        }

        public async Task<T> GetFirstAsync(bool isTracking = true)
        {
            if (isTracking)
            {
                return await Entity.FirstOrDefaultAsync();
            }
            else
            {
                return await Entity.AsNoTracking().FirstOrDefaultAsync();
            }
        }
    }
}
