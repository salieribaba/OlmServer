using MediatR;
using OlmServer.Application.Services.CompanyServices;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate
{
    public sealed class UcafCreateHandler : IRequestHandler<UcafCreateRequest, UcafCreateResponse>
    {
        private readonly IUcafService _ucafService;

        public UcafCreateHandler(IUcafService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<UcafCreateResponse> Handle(UcafCreateRequest request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateUcafAsync(request);
            return new();
        }
    }
}
