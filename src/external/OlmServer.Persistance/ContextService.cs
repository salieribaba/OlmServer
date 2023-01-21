using Microsoft.EntityFrameworkCore;
using OlmServer.Domain;
using OlmServer.Domain.AppEntities;
using OlmServer.Persistance.Contexts;

namespace OlmServer.Persistance
{
    public sealed class ContextService : IContextService
    {
        private readonly AppDbContext _dbContext;

        public ContextService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbContext CreateDbContextInstance(string CompanyId)
        {
            Company company = _dbContext.Set<Company>().Find(CompanyId);
            return new CompanyDbContext(company);
        }
    }
}
