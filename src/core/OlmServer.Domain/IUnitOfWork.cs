using Microsoft.EntityFrameworkCore;

namespace OlmServer.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext dbContext);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
