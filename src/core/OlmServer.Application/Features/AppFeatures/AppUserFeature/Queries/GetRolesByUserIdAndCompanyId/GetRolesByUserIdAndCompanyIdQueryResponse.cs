namespace OlmServer.Application.Features.AppFeatures.AppUserFeature.Queries.GetRolesByUserIdAndCompanyId
{
    public sealed record GetRolesByUserIdAndCompanyIdQueryResponse(
    IList<string> Roles);
}
