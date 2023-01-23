namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Login
{
    public sealed record LoginCommandResponse(string Token, string Email, string UserId, string NameLastName);
    
}
