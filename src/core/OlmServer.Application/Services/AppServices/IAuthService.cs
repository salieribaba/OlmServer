using OlmServer.Domain.AppEntities;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Services.AppServices
{
    public interface IAuthService
    {
        Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task<IList<AppUsersCompany>> GetCompanyListByUserIdAsync(string userId);
        Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId);
    }
}
