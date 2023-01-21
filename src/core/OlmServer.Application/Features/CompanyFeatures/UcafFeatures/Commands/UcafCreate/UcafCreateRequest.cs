using MediatR;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Commands.UcafCreate
{
    public sealed class UcafCreateRequest : IRequest<UcafCreateResponse>
    {
        public string CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
    }
}
