using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Queries
{
    public record GetAllMainRoleAndRoleRelationShipQueryResponse(
    List<MainRoleAndRoleRelationShip> mainRoleAndRoleRelationships);

}
