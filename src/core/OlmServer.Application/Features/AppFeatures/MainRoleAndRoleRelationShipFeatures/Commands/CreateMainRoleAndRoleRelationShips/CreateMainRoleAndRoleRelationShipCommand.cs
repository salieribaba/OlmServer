using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.CreateMainRoleAndRoleRelationShips
{
    public record CreateMainRoleAndRoleRelationShipCommand(
    string RoleId,
    string MainRoleId) : ICommand<CreateMainRoleAndRoleRelationShipResponse>;

}
