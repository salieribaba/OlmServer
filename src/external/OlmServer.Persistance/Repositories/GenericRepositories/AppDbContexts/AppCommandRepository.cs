using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;
using OlmServer.Domain.Repositories.GenericRepositories.AppDbContexts;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.Repositories.GenericRepositories.AppDbContexts
{
    public class AppCommandRepository<T> : IAppCommandRepository<T> where T : BaseEntity
    {
        public static readonly Func<AppDbContext, string, Task<T>> GetEntityById =
        EF.CompileAsyncQuery((AppDbContext context, string id) =>
        context.Set<T>().FirstOrDefault(x => x.Id == id));
        
        
        private readonly AppDbContext _context;

        public AppCommandRepository(AppDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }

        public DbSet<T> Entity { get ; set ; }

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await Entity.AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            await Entity.AddRangeAsync(entities, cancellationToken);
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
