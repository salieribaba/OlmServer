using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Persistance.Services.AppServices
{
    public sealed class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;

        public RoleService(RoleManager<AppRole> roleManager, IMapper mapper = null)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateRoleCommand request)
        {
            AppRole role = _mapper.Map<AppRole>(request);
            role.Id = Guid.NewGuid().ToString();
            _ = await _roleManager.CreateAsync(role);

        }

        public async Task DeleteAsync(AppRole appRole)
        {
            _ = await _roleManager.DeleteAsync(appRole);
        }

        public async Task<AppRole> GetByCode(string code)
        {
            AppRole role = await _roleManager.Roles.FirstOrDefaultAsync(p => p.Code == code);
            return role;
        }

        public Task<AppRole> GetById(string id)
        {
            AppRole role = _roleManager.Roles.FirstOrDefault(r => r.Id == id);
            return Task.FromResult(role);
        }

        public async Task<IList<AppRole>> GetAllRolesAsync()
        {
            IList<AppRole> roles = await _roleManager.Roles.ToListAsync();
            return roles;

        }

        public Task UpdateAsync(AppRole appRole)
        {
            return _roleManager.UpdateAsync(appRole);

        }
    }
}
