using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(string Code, string Name) : ICommand<CreateRoleComandResponse>;
}
