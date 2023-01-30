using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Queries
{
    public class GetAllMainRoleAndRoleRelationShipQueryHandler : IQueryHandler<GetAllMainRoleAndRoleRelationShipQuery, GetAllMainRoleAndRoleRelationShipQueryResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public GetAllMainRoleAndRoleRelationShipQueryHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<GetAllMainRoleAndRoleRelationShipQueryResponse> Handle(GetAllMainRoleAndRoleRelationShipQuery request, CancellationToken cancellationToken)
        {
            return new(await _roleRelationshipService
             .GetAll()
             .Include("AppRole")
             .Include("MainRole")
             .ToListAsync());



        }
    }
}
