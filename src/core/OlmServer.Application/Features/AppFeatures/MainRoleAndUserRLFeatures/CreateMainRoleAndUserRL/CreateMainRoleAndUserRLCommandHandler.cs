using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.CreateMainRoleAndUserRL
{
    public class CreateMainRoleAndUserRLCommandHandler : ICommandHandler<CreateMainRoleAndUserRLCommand, CreateMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _service;

        public CreateMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService service)
        {
            _service = service;
        }

        public async Task<CreateMainRoleAndUserRLCommandResponse> Handle(CreateMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationShip checkEntity = await _service.GetByUserIdCompanyIdAndMainRoleIdAsync(request.UserId, request.CompanyId, request.MainRoleId, cancellationToken);
            if (checkEntity != null) throw new Exception("Kullanıcı bu role zaten sahip!");

            MainRoleAndUserRelationShip mainRoleAndUserRelationship = new(
                Guid.NewGuid().ToString(), request.UserId, request.MainRoleId, request.CompanyId);

            await _service.CreateAsync(mainRoleAndUserRelationship, cancellationToken);

            return new();
        }
    }

}
