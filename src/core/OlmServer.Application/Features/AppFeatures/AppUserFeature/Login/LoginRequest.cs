using MediatR;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Login
{
    public sealed class LoginRequest: IRequest<LoginResponse>
    {
        public string EmailOrUserName { get; set; }
        public string Password { get; set; }

    }
}
