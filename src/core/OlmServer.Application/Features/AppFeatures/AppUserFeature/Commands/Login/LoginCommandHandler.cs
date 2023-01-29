using Microsoft.AspNetCore.Identity;
using OlmServer.Application.Abstractions;
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;
using OlmServer.Domain.AppEntities.Identity;
using OlmServer.Domain.Dtos;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthService _authService;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager, IAuthService authService = null)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
            _authService = authService;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _authService.GetByEmailOrUserNameAsync(request.EmailOrUserName);

            if (user == null) throw new Exception("Kullanıcı bulunamadı!");

            var checkUser = await _authService.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Şifreniz yanlış!");

            IList<AppUsersCompany> companies = await _authService.GetCompanyListByUserIdAsync(user.Id);
            IList<CompanyDto> companiesDto = companies.Select(s => new CompanyDto(
                s.Id, s.Company.Name)).ToList();

            if (companies.Count() == 0) throw new Exception("Herhangi bir şirkete kayıtlı değilsiniz!");

            LoginCommandResponse response = new(
                Token: await _jwtProvider.CreateTokenAsync(user),
                Email: user.Email,
                UserId: user.Id,
                NameLastName: user.NameLastName,
                Companies: companiesDto,
                Company: companiesDto[0]
                );

            return response;
        }
    }
}
