
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.MainRoleUpdates
{
    public record MainRoleUpdateCommand(string Id, string Title) : ICommand<MainRoleUpdateCommandResponse>;

}
