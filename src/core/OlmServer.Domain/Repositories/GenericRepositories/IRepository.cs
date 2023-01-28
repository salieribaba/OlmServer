using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories
{
    public interface IRepository<T>
    where T : BaseEntity
    {
        DbSet<T> Entity { get; set; }
    }
}
