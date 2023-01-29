﻿using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.RemoveByIdMainRoleAndUserRL
{
    public class RemoveByIdMainRoleAndUserRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndUserRLCommand, RemoveByIdMainRoleAndUserRLCommandResponse>
    {
        private readonly IMainRoleAndUserRelationshipService _service;

        public RemoveByIdMainRoleAndUserRLCommandHandler(IMainRoleAndUserRelationshipService service)
        {
            _service = service;
        }

        public async Task<RemoveByIdMainRoleAndUserRLCommandResponse> Handle(RemoveByIdMainRoleAndUserRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndUserRelationShip checkEntity = await _service.GetByIdAsync(request.Id, false);
            if (checkEntity == null) throw new Exception("Kullanıcı bu role zaten sahip değil!");

            await _service.RemoveByIdAsync(request.Id);

            return new();
        }
    }
}
