using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed record UpdateRoleCommand(string Id, string Code, string Name) : ICommand<UpdateRoleCommandResponse>;
}
