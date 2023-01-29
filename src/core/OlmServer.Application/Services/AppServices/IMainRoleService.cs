using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Services.AppServices
{
    public interface IMainRoleService
    {
        Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);
        Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken);
        Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken);
        IQueryable<MainRole> GetAll(CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<MainRole> GetByIdAsync(string id);
        Task UpdateAsync(MainRole mainRole);




    }
}
