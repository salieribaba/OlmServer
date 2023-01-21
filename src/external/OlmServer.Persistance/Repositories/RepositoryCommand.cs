using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.Repositories;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories
{
    public class RepositoryCommand<T> : IRepositoryCommand<T> where T : BaseEntity 
    {
        public static readonly Func<CompanyDbContext, string, Task<T>> GetEntityById =
            EF.CompileAsyncQuery((CompanyDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(x => x.Id == id));
        
        private CompanyDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext dbContext)
        {
            _context = dbContext as CompanyDbContext;
            Entity = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Entity.AddRangeAsync(entities);
        }


        public void Delete(T entity)
        {
            Entity.Remove(entity);

        }

        public async Task DeleteByIdAsync(string id)
        {
            var entity = await GetEntityById(_context, id);
            Entity.Remove(entity);

        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            Entity.RemoveRange(entities);

        }

        public void Update(T entity)
        {
            Entity.Update(entity);

        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            Entity.UpdateRange(entities);

        }
    }
}
