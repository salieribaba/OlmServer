
using OlmServer.Application.Messaging;
using OlmServer.Application.Services.AppServices;
using OlmServer.Domain.AppEntities;

namespace OlmServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.MainRoleUpdates
{
    public class MainRoleUpdateCommandHandler : ICommandHandler<MainRoleUpdateCommand, MainRoleUpdateCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public MainRoleUpdateCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<MainRoleUpdateCommandResponse> Handle(MainRoleUpdateCommand request, CancellationToken cancellationToken)
        {


            MainRole mainRole = await _mainRoleService.GetByIdAsync(request.Id);
            if (mainRole == null) throw new Exception("Ana rol bulunamadı!");

            if (mainRole.Title == request.Title) throw new Exception("Güncellemeye çalıştığınız ana rol adı eski adı ile aynı!");

            if (mainRole.Title != request.Title)
            {
                MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, mainRole.CompanyId, cancellationToken);
                if (checkMainRoleTitle != null) throw new Exception("Bu rol adı daha önce kullanılmış!");
            }

            mainRole.Title = request.Title;
            await _mainRoleService.UpdateAsync(mainRole);
            return new();

        }
    }
}
