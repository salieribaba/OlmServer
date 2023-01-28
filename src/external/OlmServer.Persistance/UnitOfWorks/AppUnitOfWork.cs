using OlmServer.Domain.UnitOfWorks;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.UnitOfWorks
{
    public class AppUnitOfWork : IAppUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public AppUnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           int count= await _dbContext.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
