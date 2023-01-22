using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Abstractions
{
    public interface IJwtProvider
    {
        Task<string> GenerateTokenAsync(AppUser user, List<string> roles);
        
    }
}
