
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRoles
{
    public record MainRoleCreateCommand(
        string Title,
        bool IsRoleCreatedByAdmin = false,
        string CompanyId = null
        ) : ICommand<MainRoleCreateResponse>;
}
