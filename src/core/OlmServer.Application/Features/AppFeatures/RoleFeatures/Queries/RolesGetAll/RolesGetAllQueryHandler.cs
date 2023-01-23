using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Queries.RolesGetAll
{
    public sealed class RolesGetAllQueryHandler : IQueryHandler<RolesGetAllQuery, RolesGetAllQueryResponse>
    {
        private readonly IRoleService _roleService;

        public RolesGetAllQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<RolesGetAllQueryResponse> Handle(RolesGetAllQuery request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAsync();
            return new(roles);
        }
    }
}
