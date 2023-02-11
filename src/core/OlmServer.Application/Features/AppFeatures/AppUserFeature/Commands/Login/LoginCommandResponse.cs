using OlmServer.Domain.Dtos;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.Login
{
    public sealed record LoginCommandResponse(
        TokenRefreshTokenDto Token,
        string Email,
        string UserId,
        string NameLastName,
        IList<CompanyDto> Companies,
        int Year,
        CompanyDto Company);


}
