using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using OlmServer.Persistance.Contexts;
using System.Linq.Expressions;

namespace OlmServer.Persistance.Repositories.GenericRepositories.CompanyDbContexts
{
    public class CompanyDbRepositoryQuery<T> : ICompanyDbRepositoryQuery<T> where T : BaseEntity
    {

        public static readonly Func<CompanyDbContext, string, bool, Task<T>> GetEntityById =
         EF.CompileAsyncQuery((CompanyDbContext context, string id, bool isTracking) =>
        context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id));


        private CompanyDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = dbContext as CompanyDbContext;
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

        public async Task<T> GetByExpressionAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default, bool isTracking = true)
        {
            T entity;
            if (!isTracking)
                entity = await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync();
            else
                entity = await Entity.Where(expression).FirstOrDefaultAsync();

            return entity;
        }
    }
}
