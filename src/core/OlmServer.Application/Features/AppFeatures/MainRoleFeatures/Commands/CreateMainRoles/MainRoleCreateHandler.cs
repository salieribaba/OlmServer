
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRoles
{
    public class MainRoleCreateHandler : ICommandHandler<MainRoleCreateCommand, MainRoleCreateResponse>
    {
        private readonly Services.AppServices.IMainRoleService _mainRoleService;

        public MainRoleCreateHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<MainRoleCreateResponse> Handle(MainRoleCreateCommand request, CancellationToken cancellationToken)
        {
            MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, request.CompanyId, cancellationToken);

            if (checkMainRoleTitle != null) throw new Exception("Bu rol daha önce kaydedilmiş!");

            MainRole mainRole = new(
                Guid.NewGuid().ToString(),
               request.Title,
              request.CompanyId != null ? false : true,
               request.CompanyId

                );
            await _mainRoleService.CreateAsync(mainRole, cancellationToken);
            return new();
        }
    }
}
