using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.CreateMainRoleAndRoleRelationShips
{
    public class CreateMainRoleAndRoleRelationShipHandler : ICommandHandler<CreateMainRoleAndRoleRelationShipCommand, CreateMainRoleAndRoleRelationShipResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public CreateMainRoleAndRoleRelationShipHandler(IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService)
        {
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
        }

        public async Task<CreateMainRoleAndRoleRelationShipResponse> Handle(CreateMainRoleAndRoleRelationShipCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationShip checkRoleAndMainRoleIsRelated = await _mainRoleAndRoleRelationshipService.GetByRoleIdAndMainRoleId(request.RoleId, request.MainRoleId, cancellationToken);

            if (checkRoleAndMainRoleIsRelated != null) throw new Exception("Bu rol ilişlişi daha önce kurulmuş!");

            MainRoleAndRoleRelationShip mainRoleAndRoleRelationship = new(
            Guid.NewGuid().ToString(),
            request.RoleId,
            request.MainRoleId);

            await _mainRoleAndRoleRelationshipService.CreateAsync(mainRoleAndRoleRelationship, cancellationToken);
            return new();
        }
    }
}
