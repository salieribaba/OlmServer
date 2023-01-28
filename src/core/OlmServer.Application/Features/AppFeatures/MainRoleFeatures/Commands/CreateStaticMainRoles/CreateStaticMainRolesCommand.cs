using OlmServer.Application.Messaging;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles
{
    public record CreateStaticMainRolesCommand(
    List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesResponse>;

}
