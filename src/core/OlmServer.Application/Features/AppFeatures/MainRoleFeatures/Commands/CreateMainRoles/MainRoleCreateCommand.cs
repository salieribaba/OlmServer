
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRoles
{
    public record MainRoleCreateCommand(
        string Title,
        string CompanyId = null
        ) : ICommand<MainRoleCreateResponse>;
}
