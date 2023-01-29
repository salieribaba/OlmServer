using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public class RemoveByIdMainRoleAndRoleRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndRoleRLCommand, RemoveByIdMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public RemoveByIdMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<RemoveByIdMainRoleAndRoleRLCommandResponse> Handle(RemoveByIdMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationShip entity = await _roleRelationshipService.GetByIdAsync(request.Id);
            if (entity == null) throw new Exception("Belirtilen Ana Rol ve Rol bağlantısı bulunamadı!");

            await _roleRelationshipService.RemoveByIdAsync(request.Id);
            return new();
        }
    }
}
