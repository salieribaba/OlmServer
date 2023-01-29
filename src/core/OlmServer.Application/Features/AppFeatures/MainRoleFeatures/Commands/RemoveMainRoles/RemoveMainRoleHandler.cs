
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRoles
{
    public class RemoveMainRoleHandler : ICommandHandler<RemoveMainRoleCommand, RemoveMainRoleResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public RemoveMainRoleHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<RemoveMainRoleResponse> Handle(RemoveMainRoleCommand request, CancellationToken cancellationToken)
        {
            await _mainRoleService.RemoveByIdAsync(request.Id);
            return new RemoveMainRoleResponse();
        }
    }
}
