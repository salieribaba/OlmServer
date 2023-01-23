using OlmServer.Domain.AppEntities.Identity;

namespace OlmServer.Application.Features.AppFeatures.RoleFeatures.Queries.RolesGetAll
{
    public sealed class RolesGetAllResponse
    {
        public IList<AppRole> Roles { get; set; }
    }
}
