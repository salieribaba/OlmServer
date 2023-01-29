using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.RemoveByIdMainRoleAndUserRL
{
    public record RemoveByIdMainRoleAndUserRLCommand(
    string Id) : ICommand<RemoveByIdMainRoleAndUserRLCommandResponse>;

}
