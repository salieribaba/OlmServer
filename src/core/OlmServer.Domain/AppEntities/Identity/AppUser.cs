using Microsoft.AspNetCore.Identity;

namespace OlmServer.Domain.AppEntities.Identity
{
    public sealed class AppUser : IdentityUser<string>
    {
        public string NameLastName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
