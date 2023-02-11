using OlmServer.Application.Messaging;
using OlmServer.Application.Services.CompanyServices;
using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate
{
    public sealed class UcafCreateCommandHandler : ICommandHandler<UcafCreateCommand, UcafCreateCommandResponse>
    {
        private readonly IUcafService _ucafService;

        public UcafCreateCommandHandler(IUcafService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<UcafCreateCommandResponse> Handle(UcafCreateCommand request, CancellationToken cancellationToken)
        {
            if (request.Type != "G" && request.Type != "M") throw new Exception("Hesap planı türü Grup ya da Muavin olmalıdır!");

            UniformChartOfAccount ucaf = await _ucafService.GetByCodeAsync(request.CompanyId, request.Code, cancellationToken);
            if (ucaf != null) throw new Exception("Bu hesap planı kodu daha önce tanımlanmış!");

            await _ucafService.CreateUcafAsync(request, cancellationToken);
            return new();
        }
    }
}
