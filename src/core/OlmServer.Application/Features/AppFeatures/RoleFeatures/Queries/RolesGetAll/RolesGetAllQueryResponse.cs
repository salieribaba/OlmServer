using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Queries.RolesGetAll
{
    public sealed record RolesGetAllQueryResponse(IList<AppRole> Roles);
}
