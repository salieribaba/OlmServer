using OlmServer.Application.Messaging;
using OlmServer.Application.Services.CompanyServices;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.CreateMainUcaf
{
    public sealed class CreateMainUCAFCommandHandler : ICommandHandler<CreateMainUCAFCommand, CreateMainUCAFCommandResponse>
    {
        private readonly IUcafService _ucafService;

        public CreateMainUCAFCommandHandler(IUcafService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateMainUCAFCommandResponse> Handle(CreateMainUCAFCommand request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateMainUcafsToCompanyAsync(request.CompanyId, cancellationToken);
            return new();
        }
    }
}
