using OlmServer.Application.Messaging;
using OlmServer.Application.Services.CompanyServices;

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
            await _ucafService.CreateUcafAsync(request);
            return new();
        }
    }
}
