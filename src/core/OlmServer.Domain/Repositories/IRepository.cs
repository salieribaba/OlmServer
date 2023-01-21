using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories
{
    public interface IRepository<T> where T:BaseEntity
    {
        void SetDbContextInstance(DbContext dbContext);
        DbSet<T> Entity { get; set; }

    }
}
