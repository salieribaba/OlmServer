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
            UniformChartOfAccount ucaf = await _ucafService.GetByCode(request.Code);
            if (ucaf != null) throw new Exception("Bu hesap planı kodu daha önce tanımlanmış.");
            

            
            await _ucafService.CreateUcafAsync(request,cancellationToken);
            return new();
        }
    }
}
