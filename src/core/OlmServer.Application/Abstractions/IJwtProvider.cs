using OlmServer.Domain.AppEntities.Identity;
using OlmServer.Domain.Dtos;

namespace OlmServer.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);

    }
}
