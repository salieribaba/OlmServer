using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.Login
{
    public sealed record LoginCommand(
        string EmailOrUserName,
        string Password) : ICommand<LoginCommandResponse>;
}
