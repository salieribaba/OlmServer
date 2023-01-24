using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OlmServer.Application.Abstractions;
using OlmServer.Application.Messaging;
using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(p => p.Email == request.EmailOrUserName || p.UserName == request.EmailOrUserName).FirstOrDefaultAsync();

            if (user == null) throw new Exception("Kullanıcı bulunamadı!");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Şifre veya email yanlış!");

            List<string> roles = new();

            LoginCommandResponse response = new(
                user.Email,
                user.NameLastName,
                user.Id,
                await _jwtProvider.GenerateTokenAsync(user, roles));

            return response;
        }
    }
}
