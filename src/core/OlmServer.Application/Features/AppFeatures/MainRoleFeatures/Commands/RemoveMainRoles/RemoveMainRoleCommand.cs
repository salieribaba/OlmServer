using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRoles
{
    public record RemoveMainRoleCommand(string Id):ICommand<RemoveMainRoleResponse>;

}
