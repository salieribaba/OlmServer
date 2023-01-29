using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Persistance.Services.AppServices
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserAndCompanyRelationshipService _companyRelationService;
        private readonly IMainRoleAndUserRelationshipService _mainRoleAndUserRelationshipService;
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public AuthService(IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService, IMainRoleAndUserRelationshipService mainRoleAndUserRelationshipService = null, IUserAndCompanyRelationshipService companyRelationService = null, UserManager<AppUser> userManager = null)
        {
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
            _mainRoleAndUserRelationshipService = mainRoleAndUserRelationshipService;
            _companyRelationService = companyRelationService;
            _userManager = userManager;
        }

        public async Task<bool> CheckPasswordAsync(AppUser user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName)
        {
            return await _userManager.Users.Where(p => p.Email == emailOrUserName || p.UserName == emailOrUserName).FirstOrDefaultAsync();
        }

        public async Task<IList<AppUsersCompany>> GetCompanyListByUserIdAsync(string userId)
        {
            return await _companyRelationService.GetListByUserId(userId);
        }

        public async Task<IList<string>> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            MainRoleAndUserRelationShip mainRoleAndUserRelationship = await _mainRoleAndUserRelationshipService.GetRolesByUserIdAndCompanyId(userId, companyId);

            IList<MainRoleAndRoleRelationShip> getMainRole = await _mainRoleAndRoleRelationshipService.GetListByMainRoleIdForGetRolesAsync(mainRoleAndUserRelationship.MainRoleId);

            IList<string> roles = getMainRole.Select(s => s.AppRole.Name).ToList();
            return roles;
        }
    }
}
