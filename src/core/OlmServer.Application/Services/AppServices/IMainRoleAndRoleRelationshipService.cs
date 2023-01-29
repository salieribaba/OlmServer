using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Services.AppServices
{
    public interface IMainRoleAndRoleRelationshipService
    {
        Task CreateAsync(MainRoleAndRoleRelationShip mainRoleAndRoleRelationship, CancellationToken cancellationToken);
        Task UpdateAsync(MainRoleAndRoleRelationShip mainRoleAndRoleRelationship);
        Task RemoveByIdAsync(string id);
        IQueryable<MainRoleAndRoleRelationShip> GetAll();
        Task<MainRoleAndRoleRelationShip> GetByIdAsync(string id);
        Task<IList<MainRoleAndRoleRelationShip>> GetListByMainRoleIdForGetRolesAsync(string id);
        Task<MainRoleAndRoleRelationShip> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId, CancellationToken cancellationToken = default);
    }
}
