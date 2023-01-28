using Microsoft.EntityFrameworkCore;
using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbRepository<T>: IRepository<T> where T : BaseEntity
    {
        void SetDbContextInstance(DbContext dbContext);

    }
}
