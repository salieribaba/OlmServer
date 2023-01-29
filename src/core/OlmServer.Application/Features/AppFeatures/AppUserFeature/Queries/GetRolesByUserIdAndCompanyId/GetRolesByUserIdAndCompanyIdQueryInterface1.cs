using OlmServer.Application.Messaging;

namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed record GetRolesByUserIdAndCompanyIdQuery(
    string UserId,
    string CompanyId) : IQuery<GetRolesByUserIdAndCompanyIdQueryResponse>;
}
