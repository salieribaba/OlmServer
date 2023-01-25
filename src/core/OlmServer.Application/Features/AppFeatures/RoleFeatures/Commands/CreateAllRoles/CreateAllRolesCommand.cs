using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
    public sealed record CreateAllRolesCommand() : ICommand<CreateAllRolesCommandResponse>;

}
