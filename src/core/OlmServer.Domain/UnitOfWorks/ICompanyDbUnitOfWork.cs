using Microsoft.EntityFrameworkCore;

namespace OlmServer.Domain.UnitOfWorks
{
    public interface ICompanyDbUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext dbContext);

    }
}
