using MediatR;
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Login
{
    public sealed record  LoginCommand
        (string EmailOrUserName, string Password): ICommand<LoginCommandResponse>;
}                                           
