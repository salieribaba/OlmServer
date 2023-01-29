using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndRoleRelationShipFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public record RemoveByIdMainRoleAndRoleRLCommand(
        string Id) : ICommand<RemoveByIdMainRoleAndRoleRLCommandResponse>;

}
