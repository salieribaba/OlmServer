using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Services.AppServices
{
    public interface IMainRoleAndUserRelationshipService
    {
        Task CreateAsync(MainRoleAndUserRelationShip mainRoleAndUserRelationship, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<MainRoleAndUserRelationShip> GetByUserIdCompanyIdAndMainRoleIdAsync(string userId, string companyId, string mainRoleId, CancellationToken cancellationToken);

        Task<MainRoleAndUserRelationShip> GetByIdAsync(string id, bool tracking);

        Task<MainRoleAndUserRelationShip> GetRolesByUserIdAndCompanyId(string userId, string companyId);
    }
}
