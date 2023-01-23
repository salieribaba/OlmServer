using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed record DeleteRoleCommand(string Id) : ICommand<DeleteRoleCommandResponse>;
}
