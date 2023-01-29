using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Services.AppServices
{
    public interface IUserAndCompanyRelationshipService
    {
        Task CreateAsync(AppUsersCompany userAndCompanyRelationship, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);
        Task<AppUsersCompany> GetByIdAsync(string id);
        Task<AppUsersCompany> GetByUserIdAndCompanyId(string userId, string companyId, CancellationToken cancellationToken);
        Task<IList<AppUsersCompany>> GetListByUserId(string userId);
    }
}
