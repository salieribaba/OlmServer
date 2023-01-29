namespace OlmServer.Domain.Dtos
{
    public record TokenRefreshTokenDto(
    string Token,
    string RefreshToken,
    DateTime RefreshTokenExpires);

}
