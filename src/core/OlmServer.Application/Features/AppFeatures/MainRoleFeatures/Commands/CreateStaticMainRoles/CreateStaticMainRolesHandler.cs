using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.Roles;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public sealed class CreateStaticMainRolesCommandHandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public CreateStaticMainRolesCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<CreateStaticMainRolesResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
        {
            List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
            List<MainRole> newMainRoles = new List<MainRole>();
            foreach (var mainRole in mainRoles)
            {
                MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyId(mainRole.Title, mainRole.CompanyId, cancellationToken);
                if (checkMainRole == null) newMainRoles.Add(mainRole);
            }

            await _mainRoleService.CreateRangeAsync(newMainRoles, cancellationToken);
            return new();
        }
    }
}