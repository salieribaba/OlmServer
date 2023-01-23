using MediatR;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Queries.RolesGetAll
{
    public sealed class RolesGetAllHandler : IRequestHandler<RolesGetAllRequest, RolesGetAllResponse>
    {
        private readonly IRoleService _roleService;

        public RolesGetAllHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<RolesGetAllResponse> Handle(RolesGetAllRequest request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAsync();
            return new()
            {
                Roles = roles
            };
        }
    }
}
