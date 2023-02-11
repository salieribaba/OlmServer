using OlmServer.Domain.CompanyEntities;

namespace OlmServer.Application.Features.CompanyFeatures.UcafFeatures.Queries.GetAllUcaf
{
    public sealed record GetAllUCAFQueryResponse(IList<UniformChartOfAccount> Data);
}
