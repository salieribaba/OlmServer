using Microsoft.EntityFrameworkCore;

namespace OlmServer.Domain
{
    public interface IContextService
    {
        DbContext CreateDbContextInstance(string CompanyId);
    }
}
