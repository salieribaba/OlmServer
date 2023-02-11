using OlmServer.Application.Messaging;
using OlmServer.Application.Services.CompanyServices;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Queries.GetAllUcaf
{
    public sealed class GetAllUCAFQueryHandler : IQueryHandler<GetAllUCAFQuery, GetAllUCAFQueryResponse>
    {
        private readonly IUcafService _ucafService;

        public GetAllUCAFQueryHandler(IUcafService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<GetAllUCAFQueryResponse> Handle(GetAllUCAFQuery request, CancellationToken cancellationToken)
        {
            return new(await _ucafService.GetAllAsync(request.CompanyId));
        }
    }
}
