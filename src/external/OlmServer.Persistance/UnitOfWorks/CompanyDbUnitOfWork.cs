using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.UnitOfWorks;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance.UnitOfWorks
{
    public sealed class CompanyDbUnitOfWork : ICompanyDbUnitOfWork
    {
        private CompanyDbContext _dbContext;
        public void SetDbContextInstance(DbContext dbContext)
        {
            _dbContext = (CompanyDbContext)dbContext;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            int count = await _dbContext.SaveChangesAsync(cancellationToken);
            return count;

        }
    }
}
