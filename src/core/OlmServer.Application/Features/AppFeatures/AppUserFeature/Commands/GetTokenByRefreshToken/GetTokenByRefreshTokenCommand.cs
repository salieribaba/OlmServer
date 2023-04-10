
using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.GetTokenByRefreshToken
{
    public record GetTokenByRefreshTokenCommand(string RefreshToken, string UserId, string CompanyId) : ICommand<GetTokenByRefreshTokenCommandResponse>;

}
