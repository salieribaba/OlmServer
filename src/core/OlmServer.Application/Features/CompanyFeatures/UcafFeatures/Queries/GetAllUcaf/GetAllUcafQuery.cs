using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Queries.GetAllUcaf
{
    public sealed record GetAllUCAFQuery(string CompanyId) : IQuery<GetAllUCAFQueryResponse>;
}
